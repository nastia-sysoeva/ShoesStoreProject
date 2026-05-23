using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Npgsql;
using ShoesStoreProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreProject.Data
{
    internal class Database
    {

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("host=localhost ; port=5432 ; username=postgres ; database=shoes_store ; password=strong_password");
        }


        // Получить пользователя по логину и паролю
        public UserModel GetUser(string login, string password)
        {

            try
            {

                using var conn = GetConnection();

                conn.Open();

                var sql = @$" select r.name, u.name, u.surname, u.patronymic
                            from roles r, users u
                            where
                            r.id = u.role AND
                            u.login = @login AND
                            u.password = @password ";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("password", password);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var user = new UserModel
                    {
                        Role = reader.GetString(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Patronymic = reader.GetString(3),
                    };
                    return user;
                }
                else
                {
                    var user = new UserModel
                    {
                        Role = "Гость"
                    };
                    return user;
                }
            }

            catch
            {
                var user = new UserModel
                {
                    Role = "Гость"
                };
                return user;
            }

        }

        
        public List<Product> GetProducts(string search, string sort, string filter)
        {

            try
            {

                var products = new List<Product>();

                using var conn = GetConnection();

                conn.Open();


                // Формирование условия для фильтрации
                var filterSql = "";
                if (filter != "Все поставщики")
                {
                    filterSql = $"s.name = '{filter}' AND "; 
                }


                var sql = @$"select p.id, p.article, p.name, p.price,
                                p.supplier, s.name,
                                p.producer, pr.name,
                                p.category, c.name,
                                p.discount,
                                p.in_stock,
                                p.description,
                                p.photo_name,
                                p.unit
                                from products p, suppliers s, producers pr, categories c
                                where
                                p.supplier = s.id AND
                                p.producer = pr.id AND
                                p.category = c.id AND 
                                {filterSql} 
                                (p.article ILIKE @search OR p.name ILIKE @search OR
                                s.name ILIKE @search OR pr.name ILIKE @search OR 
                                c.name ILIKE @search OR p.description ILIKE @search ) 
                            order by p.in_stock {sort}";

                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("search", $"%{search}%");

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var product = new Product
                    {
                        Id = reader.GetInt32(0),
                        Article = reader.GetString(1),
                        Name = reader.GetString(2),
                        Price = reader.GetDecimal(3),
                        SupplierId = reader.GetInt32(4),
                        Supplier = reader.GetString(5),
                        ProducerId = reader.GetInt32(6),
                        Producer = reader.GetString(7),
                        CategoryId = reader.GetInt32(8),
                        Category = reader.GetString(9),
                        Discount = reader.GetInt32(10),
                        InStock = reader.GetInt32(11),
                        Description = reader.GetString(12),
                        PhotoName = reader.GetString(13),
                        Unit = reader.GetString(14)
                    };

                    products.Add(product);

                }

                return products;
            }

            catch
            {
                var products = new List<Product>();
                return products;
            }

        }


        // Добавить товар
        public int AddProduct(Product newProduct)
        {
            try
            {

                using var conn = GetConnection();

                conn.Open();


                var sqlProducer = @$"select id from producers where name = @producer";

                using var cmdProducer = new NpgsqlCommand(sqlProducer, conn);
                cmdProducer.Parameters.AddWithValue("producer", newProduct.Producer);
         

                var producerId = cmdProducer.ExecuteScalar();


                var sqlSupplier = @$"select id from suppliers where name = @supplier";

                using var cmdSup = new NpgsqlCommand(sqlSupplier, conn);
                cmdSup.Parameters.AddWithValue("supplier", newProduct.Supplier);


                var supplierId = cmdSup.ExecuteScalar();


                var sqlCat = @$"select id from categories where name = @category";

                using var cmdCat = new NpgsqlCommand(sqlCat, conn);
                cmdCat.Parameters.AddWithValue("category", newProduct.Category);


                var catId = cmdCat.ExecuteScalar();



                var sql = @$" insert into products (name, price, supplier, producer, category, discount, in_stock, description, photo_name)
                                values (@name, @price, @supplier, @producer, @category, @discount, @in_stock, @description, @photo_name) ";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("name", newProduct.Name);
                cmd.Parameters.AddWithValue("price", newProduct.Price);
                cmd.Parameters.AddWithValue("supplier", supplierId);
                cmd.Parameters.AddWithValue("producer", producerId);
                cmd.Parameters.AddWithValue("category", catId);
                cmd.Parameters.AddWithValue("discount", newProduct.Discount);
                cmd.Parameters.AddWithValue("in_stock", newProduct.InStock);
                cmd.Parameters.AddWithValue("description", newProduct.Description);
                cmd.Parameters.AddWithValue("photo_name", newProduct.PhotoName);

                return cmd.ExecuteNonQuery();

            }

            catch
            {
                return -1;
            }

        }





        // Редактировать товар
        public int UpdateProduct(Product newProduct)
        {
            try
            {

                using var conn = GetConnection();

                conn.Open();


                var sqlProducer = @$"select id from producers where name = @producer";

                using var cmdProducer = new NpgsqlCommand(sqlProducer, conn);
                cmdProducer.Parameters.AddWithValue("producer", newProduct.Producer);


                var producerId = cmdProducer.ExecuteScalar();


                var sqlSupplier = @$"select id from suppliers where name = @supplier";

                using var cmdSup = new NpgsqlCommand(sqlSupplier, conn);
                cmdSup.Parameters.AddWithValue("supplier", newProduct.Supplier);


                var supplierId = cmdSup.ExecuteScalar();


                var sqlCat = @$"select id from categories where name = @category";

                using var cmdCat = new NpgsqlCommand(sqlCat, conn);
                cmdCat.Parameters.AddWithValue("category", newProduct.Category);


                var catId = cmdCat.ExecuteScalar();



                var sql = @$" update products set name = @name, price = @price, supplier = @supplier, producer = @producer, category = @category, 
                              discount = @discount, in_stock = @in_stock, description = @description, photo_name = @photo_name
                              where id = @id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("name", newProduct.Name);
                cmd.Parameters.AddWithValue("price", newProduct.Price);
                cmd.Parameters.AddWithValue("supplier", supplierId);
                cmd.Parameters.AddWithValue("producer", producerId);
                cmd.Parameters.AddWithValue("category", catId);
                cmd.Parameters.AddWithValue("discount", newProduct.Discount);
                cmd.Parameters.AddWithValue("in_stock", newProduct.InStock);
                cmd.Parameters.AddWithValue("description", newProduct.Description);
                cmd.Parameters.AddWithValue("photo_name", newProduct.PhotoName);
                cmd.Parameters.AddWithValue("id", newProduct.Id);

                return cmd.ExecuteNonQuery();

            }

            catch
            {
                return -1;
            }

        }



        // Удалить товар
        public int DeleteProduct(Product product)
        {
            try
            {
                using var conn = GetConnection();

                conn.Open();


                var sqlCheck = @$" select count(*) from products_in_orders where product = @id ";
                using var cmdCheck = new NpgsqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("id", product.Id);
                
                var ordersCount = (long)cmdCheck.ExecuteScalar();
                if (ordersCount > 0)
                {
                    MessageBox.Show("Нельзя удалить товар, присутствующий в заказах.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            

                var sql = @$" delete from products
                              where id = @id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", product.Id);
                return cmd.ExecuteNonQuery();

            }

            catch
            {
                return -1;
            }

        }



        // Получить все товары
        public List<Order> GetOrders()
        {

            try
            {

                var orders = new List<Order>();

                using var conn = GetConnection();

                conn.Open();


                var sql = @$"select p.id, p.article, p.order_date, p.delivery_date,
                                p.address, a.name,
                                p.status, s.name

                                from orders p, addresses a, statuses s
                                where
                                p.address = a.id AND
                                p.status = s.id  ";

                using var cmd = new NpgsqlCommand(sql, conn);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var order = new Order
                    {
                        Id = reader.GetInt32(0),
                        Article = reader.GetString(1),
                        OrderDate = DateOnly.FromDateTime( reader.GetDateTime(2) ),
                        DeliveryDate = DateOnly.FromDateTime( reader.GetDateTime(3) ),
                        AddressId = reader.GetInt32(4),
                        Address = reader.GetString(5),
                        StatusId = reader.GetInt32(6),
                        Status = reader.GetString(7)

                    };

                    orders.Add(order);

                }

                return orders;
            }

            catch
            {
                var orders = new List<Order>();
                return orders;
            }

        }



        public List<Address> GetAddresses()
        {

            try
            {

                var addresses = new List<Address>();

                using var conn = GetConnection();

                conn.Open();

                var sql = @$" select * from addresses";

                using var cmd = new NpgsqlCommand(sql, conn);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var address = new Address
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };


                    addresses.Add(address);

                }

                return addresses;

            }

            catch
            {
                var addresses = new List<Address>();
                return addresses;
            }

        }




        public List<Address> GetStatuses()
        {

            try
            {

                var statuses = new List<Address>();

                using var conn = GetConnection();

                conn.Open();

                var sql = @$" select * from statuses";

                using var cmd = new NpgsqlCommand(sql, conn);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var status = new Address
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };


                    statuses.Add(status);

                }

                return statuses;

            }

            catch
            {
                var statuses = new List<Address>();
                return statuses;
            }

        }



        // Добавить товар
        public int AddOrder(Order newOrder)
        {
            try
            {

                using var conn = GetConnection();

                conn.Open();

                var sql = @$" insert into orders (article, status, address, order_date, delivery_date)
                                values (@article, @status, @address, @order_date, @delivery_date) ";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("article", newOrder.Article);
                cmd.Parameters.AddWithValue("status", newOrder.StatusId);
                cmd.Parameters.AddWithValue("address", newOrder.AddressId);
                cmd.Parameters.AddWithValue("order_date", newOrder.OrderDate);
                cmd.Parameters.AddWithValue("delivery_date", newOrder.DeliveryDate);


                return cmd.ExecuteNonQuery();

            }

            catch
            {
                return -1;
            }

        }




        // Редактировать заказ
        public int UpdateOrder(Order newOrder)
        {
            try
            {

                using var conn = GetConnection();

                conn.Open();



                var sql = @$" update orders set article = @article, status = @status, address = @address, order_date = @order_date, delivery_date= @delivery_date
                              where id = @id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("article", newOrder.Article);
                cmd.Parameters.AddWithValue("status", newOrder.StatusId);
                cmd.Parameters.AddWithValue("address", newOrder.AddressId);
                cmd.Parameters.AddWithValue("order_date", newOrder.OrderDate);
                cmd.Parameters.AddWithValue("delivery_date", newOrder.DeliveryDate);

                cmd.Parameters.AddWithValue("id", newOrder.Id);

                return cmd.ExecuteNonQuery();

            }

            catch
            {
                return -1;
            }

        }





    }
}
