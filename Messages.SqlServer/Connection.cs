using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Messages.Models;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Diagnostics;

namespace Messages.SqlServer
{
    public class Connection
    {
        public static int MyId { get; set; } = 1;

        private static string _connectionString = $@"Server=.\SQLEXPRESS; Database=messaging; User Id=Admin; Password=Admin; Integrated Security=False;";
        
        public static void SendMessage(string message, int senderId, int receiverId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"
INSERT INTO [dbo].[message]
           ([text]
           ,[sender_id]
           ,[receiver_id]
           ,[time_read_by_receiver]
           ,[time_send]
           ,[is_deleted_for_sender]
           ,[is_deleted_for_receiver])
     VALUES
           (@text
           ,@senderId
           ,@receiverId
           ,@timeRead
           ,@timeSend
           ,@isDeletedSender
           ,@isDeletedUser)
";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@text", SqlDbType.Text).Value = message;
                command.Parameters.AddWithValue("@senderId", SqlDbType.Int).Value = senderId;
                command.Parameters.AddWithValue("@receiverId", SqlDbType.Int).Value = receiverId;
                command.Parameters.AddWithValue("@timeRead", SqlDbType.DateTime);
                command.Parameters.AddWithValue("@timeSend", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.AddWithValue("@isDeletedSender", SqlDbType.Bit).Value = 0;
                command.Parameters.AddWithValue("@isDeletedUser", SqlDbType.Bit).Value = 0;
                command.ExecuteNonQuery();
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public static IEnumerable<Message> GetMessages(int senderId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM message";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            List<Message> messages = dataTable.AsEnumerable().Select(dataRow => new Message()
                            {
                                MessageId = dataRow.Field<int>("message_id"),
                                Text = dataRow.Field<string>("text"),
                                SenderId = dataRow.Field<int>("sender_id"),
                                ReceiverId = dataRow.Field<int>("receiver_id"),
                                DateTimeSend = dataRow.Field<DateTime>("time_send"),
                                DateTimeRead = dataRow.Field<DateTime>("time_read_by_receiver"),
                                IsDeletedForReceiver = dataRow.Field<bool>("is_deleted_for_receiver"),
                                IsDeletedForSender = dataRow.Field<bool>("is_deleted_for_sender"),
                                Alignment = dataRow.Field<int>("sender_id") == MyId ? Alignment.Right : Alignment.Left,
                            }).ToList();

                            return messages;
                        }
                    }
                }
            }
            return null;
        }
    }
}
