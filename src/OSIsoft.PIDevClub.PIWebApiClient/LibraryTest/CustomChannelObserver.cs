using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public class CustomChannelObserver : IObserver<PIItemsStreamValues>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnNext(PIItemsStreamValues value)
        {
            foreach(PIStreamValues item in value.Items)
            {
                foreach (PITimedValue subItem in item.Items)
                {
                    Console.WriteLine("\n\nName={0}, Path={1}, WebId={2}, Value={3}, Timestamp={4}", item.Name, item.Path, item.WebId, subItem.Value, subItem.Timestamp);
                }
            }
        }
    }
}

