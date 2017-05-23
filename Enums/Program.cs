using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    #region Enum definistion 1
    /* Why Enum are requierd 
     what are the problem of not using enums 
     what is an enum ? an enum strongly type constent in this program we not use enum and see what are the 
     problems and the we replace those numbers with enum next sission lets see 
     lets say i want a customer class this customer class gonna have two properties goto 2 */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region 3
            #endregion
            Customer[] customers = new Customer[3];
            //cutomers of ziro = new customer and we pass name and gender lets create two more customers  
            customers[0] = new Customer
            {
                Name = "Mursal",
                Gender = 2
            };
            customers[1] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };
            customers[2] = new Customer
            {
                Name = "Mike",
                Gender = 0
            };
            // then what we want to do to print customers from this arrays to do that we use foreach loop
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name={0}&& Gender={1}",customer.Name,GetGender(customer.Gender));
                // because gender is intger it print number an it didnot make sence
                 # region 4
                //Name=Mursal&& Gender=2
                // Name = Mark && Gender = 1
                // Name = Mike && Gender = 0
                // Press any key to continue . . .
                // so what we need to do create another method to that method you pass the gender and that method
                //dicide ok if its ziro its unknown if its 1 its male .......lets write that method now Get gender method
                //and the return going to string male female or unkown
                #endregion
            }

        }
        public static string GetGender(int Gender)
        {
            switch (Gender)
            {
                case 0:
                    return "Unkown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "invalid data";
                    #region 5
                    /*what we need to do we will call this method and pass to the gender ID GetGender(customer.Gender) */
                    #endregion
            }
        }

    }
    #region 2
    /*if the gender =0 that means the gender is unkonwn 
     if the gender =1 that means the gender is male 
     if the gender =2 that means the gender is female
     now lets say want to create a customer list goto 3*/
    #endregion
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
