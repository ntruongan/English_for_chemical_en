using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English
{
    public partial class Form1 : Form
    {
        public List<string> KHHH = new List<string>();
        public List<int> SoCauHoi = new List<int>();
        public List<string> Ans = new List<string>();
        public List<Label> Qustion = new List<Label>();
        public List<TextBox> TxtAns = new List<TextBox>();


        public List<string> DapAnDungCu = new List<string>();
        public List<string> CauHoiDungCu = new List<string>();
        public List<int> SoCauHoiCongCu = new List<int>();
        public List<Label> QustionDC = new List<Label>();
        public List<TextBox> TxtAnsDC = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
        }
        public bool not_in(List<int> a, int k)
        {
            for (int i = 0; i < a.Count; i++)
                if (a[i] == k)
                    return false;
            return true;
        }
        void LoadData()
        {
            string[] dc = {
            "safety goggles",
            "hand gloves",
            "beaker",
            "test tube",
            "well plate",
            "test tube holder",
            "test tube brush",
            "test tube racks",
            "florence flask",

            "erlenmeyer flask",
            "graduated cylinder",
            "volumetric flask",
            "dropper",
            "watch glass",
            "evaporating dish",
            "petri dish",
            "crucible",
            "tongs",
            "reagent bottle",
            "bunsen burner",
            "alcohol burner",
            "iron ring",

            "tripod",
            "wire gauge",
            "funnel",
            "separating funnel",
            "spatula",

            "stirring rod",
            "mortar and pestle",
            "thermometer",
            "microscope",
            "analytical balance",
            "spring balance",
            "centrifuge",
            "fume hood",
            "oven",
            "Magnetic stirrer",
            "water bath"



            };
            List<string> dungcu = new List<string>(dc);
            DapAnDungCu.AddRange(dungcu);

            string[] cauhoidc = {
            "close-fitting glasses with side shields, for protecting the eyes from glare, dust, water, etc.",
            "pieces of clothing which cover your hands and wrists and have individual sections for each finger.",
            "a simple container for stirring, mixing and heating liquids commonly used in many laboratories; generally cylindrical in shape, with a flat bottom and a lip for pouring.",
            "aka a culture tube or sample tube; a thin glass tube closed at one end, used to hold small amounts of material for laboratory testing or experiments",
            "a flat plate with multiple wells used as small test tubes. It is used when we want to perform many “small-scale” reactions at one time.",


                        "designed to hold test tubes.",
            "it is long and narrow, used to clean the inside of glassware,particularly test tubes; often made with nylon bristles attached to a twisted-wire shaft.",
            "a convenient and necessary piece of laboratory equipment for holding test tubes.",
            "A glass flask with a round body used for holding chemical liquids. Normally with a round bottom for uniform heating, but may have a flattened base to stand on a flat surface without support.",


                        "aka conical flask, is a widely used type of laboratory flask which features a flat bottom, a conical body, and a cylindrical neck; suitable for heating liquids. The small neck reduces evaporative losses compared to a beaker, while the flat bottom makes it unlikely to tip over and spill.",
            "used to accurately measure the volume of a liquid; generally more accurate and precise for this purpose than flasks and beakers. It has a long cylindrical body. ",
            "a type of laboratory flask, used in analytical chemistry for the preparation of solutions; calibrated to contain a precise volume at a particular temperature.",
            "An instrument used to dispense small amount of liquids, usually drop by drop",


                        "a circular concave piece of glass used in chemistry as a surface to evaporate a liquid, to hold solids while being weighed, for heating a small amount of substance and as a cover for a  beaker.",
            "used to evaporate excess solvents - most commonly water - to produce a concentrated solution or a solid precipitate of the dissolved substance. Most are made of porcelain or borosilicate glass. Shallow glass ones are commonly termed watch glasses.",
            "named after the German bacteriologist Julius Petri; is a shallow cylindrical glass or plastic lidded dish that biologists use to culture cells– such as bacteria or small mosses.",
            "a ceramic container capable of withstanding extremely high temperatures; it is used for metal, glass, and pigment production as well as a number of modern laboratory processes. While it historically was usually made from clay, it can be made from any material that withstands temperatures high enough to melt or alter its contents. ",
            "used to hold many different things such as flasks, crucibles, and evaporating dishes when they are hot.",
            "containers made of glass or plastic, topped by special caps or stoppers; used to store chemicals in liquid or powder form for laboratories and stored in cabinets or on shelves. ",
            "a common piece of laboratory equipment  that produces a single open gas flame, which is used for heating, sterilization, and combustion.",
            "used to produce an open flame, are preferred for some uses over Bunsen burners for safety purposes, as their flame is limited to approximately two inches in height, with a comparatively lower temperature .",
            "holds glassware such as a funnels or other objects, like the wire gauze or clay triangle for heating with a Bunsen burner; often attached to an iron stand. "
            ,
                        "a three-legged equipment, generally used as a platform to support and hold various flasks, beakers and other glass ware when not in use and also during experiments. ",
            "a sheet of thin metal that has net-like crosses or a wire mesh. The purpose of it is to be placed on the support ring that is attached to the ring stand between the Bunsen burner and the beakers to support the beakers or flask during heating.",
            "a pipe with a wide, often conical mouth and a narrow stem. It is used to channel liquid or fine-grained substances into containers with a small opening.",
            "used in liquid-liquid extraction to separate the components of a mixture into two immiscible solvents  phases of different densities (partitions).",
            "used to take and handle small quantities of solid chemicals. It is used like a spoon or an instrument for scooping material out of a container. "
            ,

                        " used to mix chemicals and liquids for laboratory purposes. They are usually made of solid glass, about the thickness and slightly longer than a drinking straw.",
            "They are used to crush, grind, and mix solid substances. The substance to be ground is placed in the mortar and ground, crushed or mixed with the pestle.",
            "Used to measure temperatures.",
            "an instrument used to see objects that are too small for the naked eye.",
            "is used to measure masses with a high degree of precision and accuracy. It can measure up to 3 or 4 decimal places.",
            "a spring fixed at one end with a hook to attach an object at the other. It measures the weight of an object by opposing the force of gravity with the force of an extended spring.",
            "a machine with a rapidly rotating container that applies centrifugal force to its contents, typically to separate fluids of different densities (e.g. cream from milk) or liquids from solids",
            "typically a large piece of equipment enclosing five sides of a work area, the bottom of which is most commonly located at a standing work height.",
            " are ovens for high-forced volume thermal convection applications. These ovens generally provide uniform temperatures throughout. Process applications for laboratory ovens can be for annealing, die-bond curing, drying, Polyimide baking, sterilizing, and other industrial laboratory functions.",
            "is a laboratory device that employs a rotating magnetic field to cause a stir bar (also called flea) immersed in a liquid to spin very quickly, thus stirring it. The rotating field may be created either by a rotating magnet or a set of stationary electromagnets, placed beneath the vessel with the liquid."
            ,
            "is laboratory equipment made from a container filled with heated water. It is used to incubate samples in water at a constant temperature over a long period of time. All water baths have a digital or an analogue interface to allow users to set a desired temperature. Utilisations include warming of reagents, melting of substrates or incubation of cell cultures. It is also used to enable certain chemical reactions to occur at high temperature"
            };
            List<string> chdc = new List<string>(cauhoidc);
            CauHoiDungCu.AddRange(chdc);

            string[] akhhh = {
            "calcium sulfite",
            "lead (II) hidroxide",
            "copper (II) dichromate",
            "hidrogen fluorite",
            "silicon tetrachloride",
            "bromous acid",
            "sulfuric acid",
            "carbon disulfide",
            "sodium peroxide",
            "lithium hydride",
            "copper (I) nitrite",
            "barium oxide",
            "dichlorine trioxide",
            "zinc chlorite",
            "phosphorus pentabromide",
            "dinitrogen trioxide",
            "cobalt (III) hypobromite",
            "Chlorous acid",
            "ammonium sulfite",

                "nitrogen triiodide",
            "copper (II) carbonate",
            "mercury (I) sulfite",
            "sodium sulfite",
            "phosphorus tribromide",
            "iodous acid",
            "iron (II) hydrogen carbonate",
            "phosphorous acid",
            "nitrogen monoxide",
            "ammonium hydroxide",
            "carbon disulfide",
            "perbromic acid",
            "cobalt (III) bromide",
            "chlorine pentafluoride",
            "sodium peroxide",
            "ammonium dihydrogen phosphate",
            "lithium hypochlorite",
            "calcium hydrogen phosphate",
            "tin (IV) dichromate",
            "phosphoric acid",


                        "ammonium carbonate",
            "chromium (III) cyanide",
            "vanadium (V) oxide",
            "sodium chlorite",
            "potassium bromide",

                         "potassium hydrogen phosphate",
            "lead (II) carbonate",
            "aluminum nitride",
            "lithium hydride",
            "lead (IV) oxide"
            };
            List<string> aname = new List<string>(akhhh);
            Ans.AddRange(aname);

            string[] khhh = {
            "CaS03",
            "Pb(OH)2",
            "CuCr2O7",
            "HF (gas)",
            "SiCl4",
            "HBrO2",
            "H2S04",
            "CS2",
            "Na2O2",
            "LiH",
            "CuN02",
            "BaO",
            "Cl2O3",
            "Zn(ClO2)2",
            "PBr5",
            "N2O3",
            "Co(BrO)3",
            "HClO2",
            "(NH4)2SO3",

                        "NI3",
            "CuCO3",
            "Hg2SO3",
            "Na2SO3",
            "PBr3",
            "HIO2",
            "Fe(HCO3)2",
            "H3PO3",
            "NO",
            "NH4OH",
            "CS2",
            "HBrO4",
            "CoBr3",
            "ClF5",
            "Na2O2",
            "NH4H2PO4",
            "LiClO",
            "CaHPO4",
            "Sn(Cr2O7)2",
            "H3PO4",


                        "(NH4)2CO3",
            "Cr(CN)3",
            "V2O5",
            "NaClO2",
            "Kbr",

             "K2HPO4",
            "PbCO3",
            "AlN",
            "LiH",
            "KH2PO4"
            };
            List<string> akhh = new List<string>(khhh);
            KHHH.AddRange(akhh);


            Random r = new Random();
            int count = KHHH.Count();
            int ran = r.Next(0, count);
            SoCauHoi.Clear();
            while (SoCauHoi.Count < 16)
            {
                if (not_in(SoCauHoi, ran))
                    SoCauHoi.Add(ran);
                else
                    ran = r.Next(0, count);
            }
            count = CauHoiDungCu.Count();
            ran = r.Next(0, count);
            while (SoCauHoiCongCu.Count < 2)
            {
                if (not_in(SoCauHoiCongCu, ran))
                    SoCauHoiCongCu.Add(ran);
                else
                    ran = r.Next(0, count);
            }



            Qustion.Add(lb1);
            Qustion.Add(lb2);
            Qustion.Add(lb3);
            Qustion.Add(lb4);
            Qustion.Add(lb5);
            Qustion.Add(lb6);
            Qustion.Add(lb7);
            Qustion.Add(lb8);
            Qustion.Add(lb9);
            Qustion.Add(lb10);
            Qustion.Add(lb11);
            Qustion.Add(lb12);
            Qustion.Add(lb13);
            Qustion.Add(lb14);
            Qustion.Add(lb15);
            Qustion.Add(lb16);

            TxtAns.Add(txt1);
            TxtAns.Add(txt2);
            TxtAns.Add(txt3);
            TxtAns.Add(txt4);
            TxtAns.Add(txt5);
            TxtAns.Add(txt6);
            TxtAns.Add(txt7);
            TxtAns.Add(txt8);
            TxtAns.Add(txt9);
            TxtAns.Add(txt10);
            TxtAns.Add(txt11);
            TxtAns.Add(txt12);
            TxtAns.Add(txt13);
            TxtAns.Add(txt14);
            TxtAns.Add(txt15);
            TxtAns.Add(txt16);


            QustionDC.Add(lb_pic1);
            QustionDC.Add(lb_pic2);

            TxtAnsDC.Add(txtAns_pic1);
            TxtAnsDC.Add(txtAns_pic2);
            for (int i = 0; i < Qustion.Count(); i++)
            {
                int indexa = SoCauHoi[i];
                string stringnow = KHHH[indexa] + ": ";
                Qustion[i].Text = stringnow;
                
            }
            for (int i = 0; i < QustionDC.Count(); i++)
            {
                int indexa = SoCauHoiCongCu[i];
                string stringnow = CauHoiDungCu[indexa] + ": ";
                QustionDC[i].Text = stringnow;

            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            double diem1cau = 0.555555555;
            int socaudung = 0;
            int num  = Qustion.Count() + QustionDC.Count();
            for (int i = 0; i < Qustion.Count(); i++)
            {
                int indexa = SoCauHoi[i];
                string stringnow = Ans[indexa];
                if (stringnow == TxtAns[i].Text.Trim())
                {
                    TxtAns[i].BackColor = Color.Aqua;
                    socaudung++;
                }
                else
                {
                    TxtAns[i].BackColor = Color.Red;
                    TxtAns[i].Text = TxtAns[i].Text +"   " +stringnow;
                }
            }

            for (int i = 0; i < QustionDC.Count(); i++)
            {
                int indexa = SoCauHoiCongCu[i];
                string stringnow = DapAnDungCu[indexa];
                if (stringnow == TxtAnsDC[i].Text.Trim())
                {
                    TxtAnsDC[i].BackColor = Color.Aqua;
                    socaudung++;
                }
                else
                {
                    TxtAnsDC[i].BackColor = Color.Red;
                    TxtAnsDC[i].Text = TxtAnsDC[i].Text + "   " + stringnow;
                }
            }
            double diem = diem1cau * socaudung;
            Math.Round(diem,3);
            if (socaudung == num)
                diem = 10;
            txtdiem.Text = diem.ToString();
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            SoCauHoi.Clear();
            SoCauHoiCongCu.Clear();
            Ans.Clear();
            KHHH.Clear();
            Qustion.Clear();
            TxtAns.Clear();
            QustionDC.Clear();
            TxtAnsDC.Clear();
            this.LoadData();

            for (int i = 0; i < TxtAns.Count(); i++)
            {
                TxtAns[i].Text = "";
                TxtAns[i].BackColor = Color.White;
            }
            txtAns_pic1.ResetText();
            txtAns_pic2.ResetText();
            txtAns_pic2.BackColor = Color.White;
            txtAns_pic1.BackColor = Color.White;
            this.txtdiem.ResetText();
        }
    }
}
