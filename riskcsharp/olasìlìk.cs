using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riskcsharp
{
    public class olasılık
    {
        private int atak_deger;
        private int def_deger;
        private List<int> atak_list;
        private List<int> def_list;
        int[] dizi = new int[2];
        private Random rasgele_deger=new Random();
       

        public olasılık()
        { 
        }   


        public void zar(ulke atak,ulke def)
        {
            atak_deger = 0;
            def_deger = 0;
            atak.sahip.zarlar.Clear();
            def.sahip.zarlar.Clear();
            int [] k; 
            
            if (atak.asker_Adedi >= 3 && def.asker_Adedi >= 3 )
            {      
                k=zarat(atak.sahip.zarlar, def.sahip.zarlar, 3, 3);
                atak.asker_Adedi += k[0];
                def.asker_Adedi +=k[1];
            }
            else if (atak.asker_Adedi >= 3 && def.asker_Adedi < 3 )
            {
                k=zarat(atak.sahip.zarlar, def.sahip.zarlar, 3, def.asker_Adedi);
                atak.asker_Adedi += k[0];
                def.asker_Adedi += k[1];
            }
            else if (atak.asker_Adedi <= 3 && def.asker_Adedi >= 3 && atak.asker_Adedi != 1 ) 
            {
               k=  zarat(atak.sahip.zarlar, def.sahip.zarlar, atak.asker_Adedi-1,3);
               atak.asker_Adedi += k[0];
               def.asker_Adedi += k[1];
            }
            else
            {

                k=zarat(atak.sahip.zarlar, def.sahip.zarlar, atak.asker_Adedi, def.asker_Adedi);
                atak.asker_Adedi += k[0];
                def.asker_Adedi += k[1];
                
            }
        }
        private int[] zarat(List<int> zarlar1,List<int> zarlar2,int adet1,int adet2) {
           
            for (int i = 0; i < adet1; i++)
            {    
                zarlar1.Add(rasgele_deger.Next(1,7));
            }

            this.atak_list= zarlar1.OrderByDescending((x=>x)).ToList();

            for (int i = 0; i < adet2; i++)
            {
                zarlar2.Add(rasgele_deger.Next(1,7));
            }

            this.def_list = zarlar2.OrderByDescending((x => x)).ToList();

            return zar_hesabı(atak_list, def_list,adet1,adet2);
        }
        private int[] zar_hesabı(List<int> atak , List<int> def,int adet1,int adet2)
        {

            for (int i = 0; i < kucukbelirle(adet1,adet2); i++)
            {
              
			  if (atak[i] > def[i] )
            {
                def_deger -= 1;// savunmadan 1 azaltacak
            }
            else if (atak[i] <= def[i] ) 
            {
                atak_deger -= 1;
            }
		}
            return new int[] {atak_deger,def_deger};
        }
        private int kucukbelirle(int a , int b)
        {         
            if (a<b)
            {
               return a;
            }
            else if (b < a)
            {
               return b;
            }
            else
            {
                return a;
            }
        }
    }
}