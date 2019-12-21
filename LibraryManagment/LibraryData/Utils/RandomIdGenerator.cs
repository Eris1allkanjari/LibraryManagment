using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Utils {
    public class RandomIdGenerator {
        public static int generateId() {
            var random = new Random();
            string id = string.Empty;
            for (int i = 0; i < 5; i++)
                id = String.Concat(id, random.Next(10).ToString());
            return Int32.Parse(id);
        }
    }
}