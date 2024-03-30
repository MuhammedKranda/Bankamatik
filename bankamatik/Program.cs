using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bankamatik

{
    internal class Program
    {       
        static void Main(string[] args)
        {
            int para = 2500;
            string password = "ab18";
            while (true)
            {
                
                    ana:
                    Console.WriteLine("kartlı işlem(0)/kartsız işlem(1) ");
                    string sçmk = Console.ReadLine();
                    switch(sçmk)
                    {
                        case "0":
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("şifre:");
                            string sıfre = Console.ReadLine();
                            if (password == sıfre)
                            {
                                
                                Console.WriteLine("********** ANA MENÜ **********");
                                Console.WriteLine("Para Çekmek için    1\nPara yatırmak için  2\nPara Transferleri   3\nEğitim Ödemeleri    4\nÖdemeler            5\nBilgi Güncelleme    6");
                                string sçma = Console.ReadLine();
                                switch(sçma)
                                {
                                    case "1":
                                        a:
                                        Console.WriteLine("********** PARA ÇEKME **********");
                                        Console.Write($"Bakiye:{para}\nÇekmek istediğniz miktar:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());
                                        if(miktar>para)
                                        {
                                            Console.WriteLine("Yetersiz bakiye!!!");
                                            goto a;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yeni bakiye:"+(para-miktar));
                                            para -= miktar;
                                            Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                            string sçm0 = Console.ReadLine();
                                            switch(sçm0)
                                            {
                                                case "9":
                                                    goto ana;
                                                    
                                                case "0":
                                                    goto exıt;
                                            }
                                        }
                                        break;
                                    case "2":
                                        Console.WriteLine("Kredi Kartına    1\nKendi Hesabınıza 2\nAna Menü        9\nÇıkmak için     0");
                                        string sçm = Console.ReadLine();
                                        switch (sçm)
                                        {
                                            case "1":
                                                don:
                                                Console.Write("12 haneli kredi kartı numaranızı girin:");
                                                string numara = Console.ReadLine();
                                                if(numara.Length==12)
                                                {
                                                    Console.WriteLine("Bakiye:"+para);
                                                    Console.Write("Yatırmak istediğiniz para miktarı:");
                                                    int miktarr = Convert.ToInt32(Console.ReadLine());
                                                    if(miktarr>para)
                                                    {
                                                        Console.WriteLine("yetersiz bakiye!!!");
                                                        goto don;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Para kredi kartınız yatırılmıştır");
                                                        Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                        string sçm0 = Console.ReadLine();
                                                        switch (sçm0)
                                                        {
                                                            case "9":
                                                                goto ana;

                                                            case "0":
                                                                goto exıt;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("12 haneli bir numara girin");
                                                    goto don;
                                                }
                                                break;
                                            case "2":
                                                Console.Write("yatırılacak para miktarı:");
                                                int mikta = Convert.ToInt32(Console.ReadLine());
                                                para += mikta;
                                                Console.WriteLine("yeni bakiye:"+para);
                                                Console.WriteLine("");
                                                Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                string sçm3 = Console.ReadLine();
                                                switch (sçm3)
                                                {
                                                    case "9":
                                                        goto ana;

                                                    case "0":
                                                        goto exıt;
                                                }
                                                break;
                                            case "9":
                                                goto ana;
                                            case "":
                                                goto exıt;


                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("********** PARA TRANSFERİ **********");
                                        Console.WriteLine("Başka Hesaba EFT    1\nBaşka Hesaba Havale 2");
                                        string sçm1 = Console.ReadLine();
                                        switch(sçm1)
                                        {
                                            case "1":
                                                Console.WriteLine("EFT numarası girin(başında TR olsun)");
                                                string numara = Console.ReadLine();
                                                Console.WriteLine("Bakiye:"+para);
                                                don:
                                                Console.WriteLine("Ne kadar para aktaracaksınız:");
                                                int istk = Convert.ToInt32(Console.ReadLine());                                                
                                                if(istk>para)
                                                {
                                                    Console.WriteLine("YETERSİZ BAKİYE !!!");
                                                    goto don;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Aktarma gerçekleşti Bakiye:"+para);
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm0 = Console.ReadLine();
                                                    switch (sçm0)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                break;
                                            case "2":
                                                hsp:
                                                Console.Write("11 haneli hesap numarası giriniz:");
                                                string no = Console.ReadLine();
                                                if(no.Length==11)
                                                {
                                                don1:
                                                    Console.WriteLine("Ne kadar para aktaracaksınız:");
                                                    int istk1 = Convert.ToInt32(Console.ReadLine());
                                                    if (istk1 > para)
                                                    {
                                                        Console.WriteLine("YETERSİZ BAKİYE !!!");
                                                        goto don1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Aktarma gerçekleşti Bakiye:" + para);
                                                        Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                        string sçm0 = Console.ReadLine();
                                                        switch (sçm0)
                                                        {
                                                            case "9":
                                                                goto ana;

                                                            case "0":
                                                                goto exıt;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("hatalı hesap numarası!!");
                                                    goto hsp;
                                                }
                                                break;

                                        }
                                        break;
                                    case "4":
                                        Console.WriteLine("sayfa arızalı!");
                                        Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                        string sçm9 = Console.ReadLine();
                                        switch (sçm9)
                                        {
                                            case "9":
                                                goto ana;

                                            case "0":
                                                goto exıt;
                                        }

                                        break;
                                    case "5":
                                        Console.WriteLine("********** ÖDEMELER **********");
                                        Console.WriteLine("Elektrik Faturası       1\nTelefon Faturası        2\nİnternet faturası       3\nSu Faturası             4\nOGS Ödemeleri           5");
                                        string oy = Console.ReadLine();
                                        switch(oy)
                                        {
                                            case "1":
                                                Console.Write("Fatura tutarı:");
                                                int tutar = Convert.ToInt32(Console.ReadLine());
                                                if(tutar>para)
                                                {
                                                    Console.WriteLine("Yetersiz bakiye");
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("işlem gerçekleştirildi"+(para-tutar));
                                                    para -= tutar;
                                                }
                                                break;
                                            case "2":
                                                Console.Write("Fatura tutarı:");
                                                int tutar1 = Convert.ToInt32(Console.ReadLine());
                                                if (tutar1 > para)
                                                {
                                                    Console.WriteLine("Yetersiz bakiye");
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("işlem gerçekleştirildi" + (para - tutar1));
                                                    para -= tutar1;
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                break;

                                            case "3":
                                                Console.Write("Fatura tutarı:");
                                                int tutar2 = Convert.ToInt32(Console.ReadLine());
                                                if (tutar2 > para)
                                                {
                                                    Console.WriteLine("Yetersiz bakiye");
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("işlem gerçekleştirildi" + (para - tutar2));
                                                    para -= tutar2;
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                break;
                                            case "4":
                                                Console.Write("Fatura tutarı:");
                                                int tutar3 = Convert.ToInt32(Console.ReadLine());
                                                if (tutar3 > para)
                                                {
                                                    Console.WriteLine("Yetersiz bakiye");
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("işlem gerçekleştirildi" + (para - tutar3));
                                                    para -= tutar3;
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                break;
                                            case "5":
                                                Console.Write("Fatura tutarı:");
                                                int tutar4 = Convert.ToInt32(Console.ReadLine());
                                                if (tutar4 > para)
                                                {
                                                    Console.WriteLine("Yetersiz bakiye");
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("işlem gerçekleştirildi" + (para - tutar4));
                                                    para -= tutar4;
                                                    Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                                    string sçm3 = Console.ReadLine();
                                                    switch (sçm3)
                                                    {
                                                        case "9":
                                                            goto ana;

                                                        case "0":
                                                            goto exıt;
                                                    }
                                                }
                                                break;



                                        }
                                        break;
                                    case "6":
                                        Console.WriteLine("********** ŞİFRE DEĞİŞTİRME **********");
                                        Console.Write("yeni şifreniz:");
                                        string ypassword = Console.ReadLine();
                                        password = ypassword;
                                        Console.WriteLine("şifreniz değiştirldi");
                                        Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                        string sçm2 = Console.ReadLine();
                                        switch (sçm2)
                                        {
                                            case "9":
                                                goto ana;

                                            case "0":
                                                goto exıt;
                                        }
                                        break;
 
                                }
                                    
                            }
                            else
                             Console.WriteLine("şifre yanlış");
                        }
                        Console.WriteLine("5 sn. sistem devre dışı");
                        Thread.Sleep(5000);
                        goto ana;
                        
                        case "1":                       
                        Console.WriteLine("********** ANA MENÜ **********");
                        string tc = "01234567890";
                        string cepno = "05001112233";
                        Console.WriteLine("CepBank Para Çekmek 1\nPara yatırmak için  2\nKredi Kartı Ödeme   3\nEğitim Ödemeleri    4\nÖdemeler            5");
                        string oy1 = Console.ReadLine();
                        switch(oy1)
                        {
                            case "1":                               
                                Console.WriteLine("********** CepBank PARA ÇEKİM **********");
                                for(int i=0;i<3;i++)
                                {
                                    Console.Write("TC kimlik no girin:");
                                    string utc = Console.ReadLine();
                                    Console.Write("Cep no girin:");
                                    string ucepno = Console.ReadLine();
                                    if(utc==tc&ucepno==cepno)
                                    {
                                        Console.WriteLine("Doğru al 1000 tl");
                                        Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                        string sçm4 = Console.ReadLine();
                                        switch (sçm4)
                                        {
                                            case "9":
                                                goto ana;

                                            case "0":
                                                goto exıt;
                                        }
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlış cep no yada tc no!!");                                        
                                    }
                                }
                                Console.WriteLine("1 saat kilitli");
                                Thread.Sleep(3600000);
                                goto ana;
                                
                            case "2":
                                Console.WriteLine("********* PARA YATIRIM **********");
                                Console.WriteLine("Nakit ödeme     1\nHesaptan ödeme  2\nAna Menü        9\nÇıkmak için     0");
                                string sçm = Console.ReadLine();
                                switch(sçm)
                                {
                                    case "1":
                                        Console.Write("Kredi kartı no girin:");
                                        string kredino = Console.ReadLine();
                                        Console.Write("TC kimlik no girin:");
                                        string utc = Console.ReadLine();
                                        if(kredino.Length==12&tc==utc)
                                        {
                                            Console.WriteLine("Ne kadar nakit alacaksınız:");
                                            Console.WriteLine("ödeme yapıldı"); 
                                            Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                            string sçm3 = Console.ReadLine();
                                            switch (sçm3)
                                            {
                                                case "9":
                                                    goto ana;

                                                case "0":
                                                    goto exıt;
                                            }

                                        }
                                        break;
                                    case "2":
                                        Console.Write("Kredi kartı no girin:");
                                        string kredino1 = Console.ReadLine();
                                        Console.Write("Hesap no girin:");
                                        Console.ReadLine();
                                        if (kredino1.Length==12)
                                        {                                           
                                            Console.WriteLine("Ödeme yapıldı");
                                            Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                            string sçm4 = Console.ReadLine();
                                            switch (sçm4)
                                            {
                                                case "9":
                                                    goto ana;

                                                case "0":
                                                    goto exıt;
                                            }
                                        }
                                        break;
                                    case "9":
                                        goto ana;                                        
                                    case "0":
                                        goto exıt;                                        
                                }
                                break;
                            case "3":
                                Console.WriteLine("");
                                break;
                            case "4":
                                Console.WriteLine("Bu safya arızalıdır");
                                Console.WriteLine("Ana meüye dönmek için   9\nÇıkmak için             0");
                                string sçm2 = Console.ReadLine();
                                switch (sçm2)
                                {
                                    case "9":
                                        goto ana;

                                    case "0":
                                        goto exıt;
                                }
                                break;
                            case "5":
                                break;
                        }
                        break;
                    }
                
                
            }
           exıt:
            Console.WriteLine("çıkılıyor..");
            Thread.Sleep(2000);
        }
    }
}
