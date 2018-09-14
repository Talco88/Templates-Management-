﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateCoreBusiness.Word;
using TemplateCoreBusiness.Database;
using TemplateCoreBusiness.Engine;
using TemplateCoreBusiness.Models;

namespace WordTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test.BasicTest();

            try
            {
                //INSERT
                /*
                //Console.WriteLine(UserEngineBuilder.GetUserEngine().RegisterNewUser("Chen", "maimaran", "03021991", "chen@gmail.com"));

                //AppEngineBuilder.GetAppEngine().CreateNewTemplate("gsdkgbsdgb", "Guy mandel", "chen@gmail.com");
                //Console.WriteLine();
                */
                createTopics();

                /*
                //SELECT
                UserEntity userInformation = UserEngineBuilder.GetUserEngine().LogInUser("chen@gmail.com", "03021991");
                Console.WriteLine();
                
                List<string> templateNames = AppEngineBuilder.GetAppEngine().GetTemplateFromSearch("Guy");
                Console.WriteLine();
                */

                List<TopicEntity> listEntities = AppEngineBuilder.GetAppEngine().getAllTopics();
                Console.WriteLine();

                List<string> headersList = AppEngineBuilder.GetAppEngine().getTopicsInCategory("מסמכים");
                Console.WriteLine();
                /*
                //DELETE
                Console.WriteLine(AppEngineBuilder.GetAppEngine().DeleteTemplate(65447));
                Console.WriteLine();
                
                Console.WriteLine(AppEngineBuilder.GetAppEngine().DeleteTopic("ברכות", "בר מצווה"));
                Console.WriteLine();
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void createTopics()
        {
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("ברכות", "הולדת הבן"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("ברכות", "הולדת הבת"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("ברכות", "יום הולדת"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("ברכות", "שנה טובה"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("ברכות", "בר מצווה"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("ברכות", "בת מצווה"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("מסמכים", "חוזה עבודה"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("מסמכים", "חוזה שכר דירה"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("מסמכים", "תביעה"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("כללי", "מייל לעובדים"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("כללי", "דפוס חוזר"));
            Console.WriteLine(AppEngineBuilder.GetAppEngine().CreateNewTopic("כללי", "דף שער"));
        }
    }
}