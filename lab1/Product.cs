using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }

    public class ProductCategory
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }
        public ProductCategory(string name)
        {
            this.Name = name;
            this.Products = new List<Product>();
        }
    }
    public class Data
    {
        public static ICollection<ProductCategory> Comp_Part { get; private set; }

        public Data()
        {
            Comp_Part = new List<ProductCategory>();
        }

        public static void Init()
        {
            /*ProductCategory gpus = new ProductCategory("GraphicCard");
            Product g1 = new Product() { Name = "Nvidia Geforce GTX 1050 Ti", Price = 500, Id = 198511 }; 
            Product g2 = new Product() { Name = "Nvidia Geforce GTX 1060 Ti", Price = 640, Id = 187515 };
            Product g3 = new Product() { Name = "Nvidia Geforce RTX 2060", Price = 710, Id = 125921 };
            Product g4 = new Product() { Name = "Nvidia Geforce RTX 2070", Price = 999, Id = 110818 };
            Product g5 = new Product() { Name = "AMD RX 470", Price = 300, Id = 158105 };
            Product g6 = new Product() { Name = "AMD RX 580", Price = 450, Id = 199182 };
            Product g7 = new Product() { Name = "AMD Radeon HD7450", Price = 840, Id = 178781 };
            Product g8 = new Product() { Name = "AMD Radeon HD7850", Price = 920, Id = 158299 };
            gpus.Products.Add(g1);
            gpus.Products.Add(g2);
            gpus.Products.Add(g3);
            gpus.Products.Add(g4);
            gpus.Products.Add(g5);
            gpus.Products.Add(g6);
            gpus.Products.Add(g7);
            gpus.Products.Add(g8);
            Comp_Part.Add(gpus);       не добавлено в код

            ProductCategory mthr = new ProductCategory("MotherBoard");
            Product m1 = new Product() { Name = "MSI B450 Tomahawk Max", Price = 230, Id = 284811 };
            Product m2 = new Product() { Name = "MSI MAG Z390 Tomahawk", Price = 290, Id = 205515 };
            Product m3 = new Product() { Name = "MSI Z390-A Pro", Price = 345, Id = 297515 };
            Product m4 = new Product() { Name = "MSI B360M Pro-VD", Price = 399, Id = 201585 };
            Product m5 = new Product() { Name = "Gigabyte GA-A320M-S 2H V2", Price = 190, Id = 291459 };
            Product m6 = new Product() { Name = "Gigabyte B450 Aorus", Price = 245, Id = 215537 };
            Product m7 = new Product() { Name = "Gigabyte B450M DS3H", Price = 280, Id = 249004 };
            Product m8 = new Product() { Name = "Gigabyte B450 Aorus M", Price = 325, Id = 259190 };
            mthr.Products.Add(m1);
            mthr.Products.Add(m2);
            mthr.Products.Add(m3);
            mthr.Products.Add(m4);
            mthr.Products.Add(m5);
            mthr.Products.Add(m6);
            mthr.Products.Add(m7);
            mthr.Products.Add(m8);
            Comp_Part.Add(mthr);


            ProductCategory hrd = new ProductCategory("HardDisk");
            Product h1 = new Product() { Name = "HDD Western Digital Blue 1TB", Price = 180, Id = 315919 };
            Product h2 = new Product() { Name = "HDD Seagate BarraCuda 2TB", Price = 220, Id = 310094 };
            Product h3 = new Product() { Name = "HDD Western Digital Purple 2TB", Price = 260, Id = 352511 };
            Product h4 = new Product() { Name = "HDD Toshiba P300 1TB", Price = 300, Id = 310951 };
            Product h5 = new Product() { Name = "SSD Kingston A400 240GB", Price = 280, Id = 386861 };
            Product h6 = new Product() { Name = "SSD Kingston HyperX Fury 3D 240GB", Price = 320, Id = 319581 };
            Product h7 = new Product() { Name = "SSD Western Digital Green 120GB", Price = 350, Id = 351776 };
            Product h8 = new Product() { Name = "SSD Western Digital Blue 500GB", Price = 400, Id = 399254 };
            hrd.Products.Add(h1);
            hrd.Products.Add(h2);
            hrd.Products.Add(h3);
            hrd.Products.Add(h4);
            hrd.Products.Add(h5);
            hrd.Products.Add(h6);
            hrd.Products.Add(h7);
            hrd.Products.Add(h8);
            Comp_Part.Add(hrd);

            ProductCategory comp = new ProductCategory("ComputerCase");
            Product c1 = new Product() { Name = "AeroCool DS 230 Black", Price = 30, Id = 492861 };
            Product c2 = new Product() { Name = "AeroCool PGS Python Tempered Glass ARGB", Price = 40, Id = 491950 };
            Product c3 = new Product() { Name = "AeroCool PGS Sentinel ARGB Glass Black", Price = 45, Id = 425168 };
            Product c4 = new Product() { Name = "AeroCool P7-C1 Tempered Glass Edition", Price = 60, Id = 490177 };
            Product c5 = new Product() { Name = "GameMax StarLight B-White", Price = 50, Id = 401952 };
            Product c6 = new Product() { Name = "GameMax Pardo White", Price = 55, Id = 477152 };
            Product c7 = new Product() { Name = "GameMax G56 1 White", Price = 60, Id = 491105 };
            Product c8 = new Product() { Name = "GameMax Aurora", Price = 99, Id = 458144 };
            comp.Products.Add(c1);
            comp.Products.Add(c2);
            comp.Products.Add(c3);
            comp.Products.Add(c4);
            comp.Products.Add(c5);
            comp.Products.Add(c6);
            comp.Products.Add(c7);
            comp.Products.Add(c8);
            Comp_Part.Add(comp);

            ProductCategory pwr = new ProductCategory("PowerSupply");
            Product p1 = new Product() { Name = "Aerocool VX Plus 500 500W", Price = 110, Id = 559195 };
            Product p2 = new Product() { Name = "Aerocool KCAS-800 Plus 800W", Price = 150, Id = 500977 };
            Product p3 = new Product() { Name = "Aerocool VS-800 800W", Price = 140, Id = 517991 };
            Product p4 = new Product() { Name = "Aerocool KCAS-700 700W", Price = 130, Id = 501852 };
            Product p5 = new Product() { Name = "Chieftec GPS-700A8 700W", Price = 190, Id = 515816 };
            Product p6 = new Product() { Name = "Chieftec GPS-600A8 600W", Price = 160, Id = 567911 };
            Product p7 = new Product() { Name = "Chieftec Proton BDF-750C 750W", Price = 210, Id = 576167 };
            Product p8 = new Product() { Name = "Chieftec GPS-1450C 1450W", Price = 345, Id = 510701 };
            pwr.Products.Add(p1);
            pwr.Products.Add(p2);
            pwr.Products.Add(p3);
            pwr.Products.Add(p4);
            pwr.Products.Add(p5);
            pwr.Products.Add(p6);
            pwr.Products.Add(p7);
            pwr.Products.Add(p8);
            Comp_Part.Add(pwr);

            ProductCategory cpu = new ProductCategory("Processor");
            Product cp1 = new Product() { Name = "Intel Core i3-8100 3.6GHz/8GT/s/6MB", Price = 180, Id = 691205 };
            Product cp2 = new Product() { Name = "Intel Core i5-8400 2.8GHz/8GT/s/9MB", Price = 240, Id = 615002 };
            Product cp3 = new Product() { Name = "Intel Core i7-5820K 3.3GHz/5GT/s/15MB", Price = 330, Id = 601285 };
            Product cp4 = new Product() { Name = "Intel Core i7-6850K 3.6GHz/15MB", Price = 350, Id = 671895 };
            Product cp5 = new Product() { Name = "AMD Ryzen 5 3600 3.6GHz/32MB", Price = 230, Id = 691878 };
            Product cp6 = new Product() { Name = "AMD Ryzen 5 1600 3.2GHz/16MB", Price = 260, Id = 691502 };
            Product cp7 = new Product() { Name = "AMD Ryzen 5 2600 3.4GHz/16MB", Price = 290, Id = 651001 };
            Product cp8 = new Product() { Name = "AMD Ryzen 7 3700X 3.6GHz/32MB", Price = 450, Id = 650502 };
            cpu.Products.Add(cp1);
            cpu.Products.Add(cp2);
            cpu.Products.Add(cp3);
            cpu.Products.Add(cp4);
            cpu.Products.Add(cp5);
            cpu.Products.Add(cp6);
            cpu.Products.Add(cp7);
            cpu.Products.Add(cp8);
            Comp_Part.Add(cpu);

            ProductCategory clr = new ProductCategory("Cooler");
            Product cl1 = new Product() { Name = "Cooler Master Silent Fan 120", Price = 15, Id = 781293 };
            Product cl2 = new Product() { Name = "Cooler Master MasterLiquid Lite 240", Price = 170, Id = 701285 };
            Product cl3 = new Product() { Name = "Cooler Master Hyper 212 EVO", Price = 20, Id = 741833 };
            Product cl4 = new Product() { Name = "Cooler Master SickleFlow 120 2000 RPM", Price = 35, Id = 781273 };
            Product cl5 = new Product() { Name = "Thermaltake Pure 12 ARGB Sync Radiator", Price = 40, Id = 792171 };
            Product cl6 = new Product() { Name = "Thermaltake Water 3.0 120 ARGB Sync", Price = 225, Id = 781257 };
            Product cl7 = new Product() { Name = "Thermaltake Riing Trio 14 RGB Radiator", Price = 50, Id = 791100 };
            Product cl8 = new Product() { Name = "Thermaltake Floe Riing RGB 360 TT", Price = 55, Id = 733452 };
            clr.Products.Add(cl1);
            clr.Products.Add(cl2);
            clr.Products.Add(cl3);
            clr.Products.Add(cl4);
            clr.Products.Add(cl5);
            clr.Products.Add(cl6);
            clr.Products.Add(cl7);
            clr.Products.Add(cl8);
            Comp_Part.Add(clr);

            ProductCategory ram = new ProductCategory("RAM");
            Product r1 = new Product() { Name = "Kingston DDR3-1600 4096MB", Price = 170, Id = 810158 };
            Product r2 = new Product() { Name = "Kingston DDR4-2400 8192MB", Price = 240, Id = 859155 };
            Product r3 = new Product() { Name = "Kingston DDR3-1600 8192MB", Price = 225, Id = 801232 };
            Product r4 = new Product() { Name = "Kingston SODIMM DDR3l-1600 8192MB", Price = 300, Id = 815700 };
            Product r5 = new Product() { Name = "HyperX DDR4-2400 4096MB", Price = 270, Id = 815187 };
            Product r6 = new Product() { Name = "HyperX DDR4-2400 8192MB", Price = 350, Id = 890155 };
            Product r7 = new Product() { Name = "HyperX DDR4-3200 16384MB", Price = 600, Id = 893201 };
            Product r8 = new Product() { Name = "HyperX DDR4-3000 16384MB", Price = 620, Id = 891887 };
            ram.Products.Add(r1);
            ram.Products.Add(r2);
            ram.Products.Add(r3);
            ram.Products.Add(r4);
            ram.Products.Add(r5);
            ram.Products.Add(r6);
            ram.Products.Add(r7);
            ram.Products.Add(r8);
            Comp_Part.Add(ram);*/
        }

    }
}
