using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Converted
{
    class Program
    {
        static void Main(string[] args)
        {
            AvadConfiguratorDataContext db = new AvadConfiguratorDataContext();
            foreach(UserSetups us in db.UserSetups.Where(x => x.PoolId == 2))
            {
                Dictionary<string, QuoteDataModel> quotelist = JsonConvert.DeserializeObject<Dictionary<string, QuoteDataModel>>(us.Data);
                Dictionary<string, QuoteNewDataModel> newquotes = new Dictionary<string, QuoteNewDataModel>();
                foreach(KeyValuePair<string,QuoteDataModel> data in quotelist)
                {
                    QuoteNewDataModel newdata = new QuoteNewDataModel();
                    newdata.cid = data.Value.cid;
                    newdata.amount = data.Value.amount;
                    newdata.created = data.Value.created;
                    newdata.id = data.Value.id;
                    newdata.list = data.Value.list;
                    newdata.name = data.Value.name;
                    newdata.qty = data.Value.qty;
                    newdata.title = data.Value.title;
                    newdata.up = data.Value.up;
                    if(db.Products.Select(x => x.ProductId).Contains(data.Value.id))
                    {
                        newdata.disabled = false;
                    }
                    else
                    {
                        newdata.disabled = true;
                    }
                    newquotes.Add(newdata.cid, newdata);
                }
                string output = JsonConvert.SerializeObject(newquotes);
                us.Data = output;
            }
            db.SaveChanges();
        }
    }
}
