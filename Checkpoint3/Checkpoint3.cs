using System;
using System.Threading;
using SimpleHttp;
using System.IO;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace WebServer
{
    class Program
    {
        static SqliteConnectionStringBuilder connectionStringBuilder = new SqliteConnectionStringBuilder();
        static string style = @"
            <style>
                .items {
                    display: flex;
                    flex-wrap: wrap;
                }
                .item {
                    min-width: 200px;
                    padding: 10px;
                    background-color: aliceblue;
                    margin: 10px;
                }
            </style>
        ";
        
        static void Main()
        {
            connectionStringBuilder.DataSource = "./databass.db";

            // keeping below for testing
            Route.Add("/", (request, response, args) => {
                response.AsText("Hello, World!");
            }, "GET");

            // adding a bit of style
            Route.Add("/tasks", (request, response, args) => {
                response.AsText($"{style}{getItems()}");
            }, "GET");

            // show tasks and their id
            Route.Add("/tasks", (request, response, args) => {
                request.ParseBody(args);
                if (args.ContainsKey("_method") && args["_method"] == "DELETE") {
                    RunQuery($@"
                        DELETE FROM todo
                        WHERE task_id = ('{args["task_id"]}');
                    ");
                } else {
                    RunQuery($@"
                        INSERT into todo (task)
                        VALUES ('{args["task"]}');
                    ");
                }
                
                response.AsText($"{style}{getItems()}");
            }, "POST");

            //run the server
            int port = 8000;
            Console.WriteLine($"Running Server On http://127.0.0.1:{port}");
            HttpServer.ListenAsync(port, CancellationToken.None, Route.OnHttpRequestAsync).Wait();
        }

        static string getItems()
        {
            var results = RunQuery($@"  
                SELECT *
                FROM todo;
            ");
            string html = $@"
                <div class='items'>
                    <div class='item'>{String.Join("</div><br /><div class='item'>", PrintResults(results).Split('\n'))}</div>
                </div>
            ";
            html += @"
                <br/><br/>
                <form method='POST' action='/tasks'>
                    <label>New Task
                    <input name='task' />
                    </label>
                    <input type='submit' value='Submit' />
                </form>
                <br/>
                <form method='POST' action='/tasks'>
                    <input type='hidden' name='_method' value='DELETE' />
                    <label>Remove Task by ID
                        <input name='task_id' />
                    </label>
                    <input type='submit' value='Delete' />
                </form>
            ";
            return html;
        }
        // maybe use later
        //  <label>Container
        //      <select name='container_id'>
        //          <option value='1'>Austin-1</option>
        //          <option value='2'>San Antonio-1</option>
        //          <option value='3'>Houston-1</option>
        //          <option value='4'>Dallas-1</option>
        //      </select>
        //  </label>

        static List<Dictionary<string, string>> RunQuery(string query)
        {
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = query;
                SqliteDataReader reader = selectCmd.ExecuteReader();
                List<Dictionary<string, string>> results = getResults(reader);
                reader.Close();
                connection.Close();
                return results;
            }
        }

        static List<Dictionary<string, string>> getResults(SqliteDataReader reader)
        {
            List<Dictionary<string, string>> results = new List<Dictionary<string, string>>();
            int row = 0;
            while (reader.Read()){
                results.Add(new Dictionary<string, string>());
                for (var column = 0; column < reader.FieldCount; column++)
                {
                    results[row].Add(reader.GetName(column), reader.GetString(column));
                }
                row++;
            }
            return results;
        }

        static string PrintResults(List<Dictionary<string, string>> results)
        {
            string resultsString = "";
            foreach (var result in results)
            {
                System.Collections.Generic.IEnumerable<string> lines = result.Select(kvp => kvp.Key + ": " + kvp.Value);
                resultsString += $"{String.Join("<br/>", lines)}\n";
            }
            return resultsString;
        }
    }
}