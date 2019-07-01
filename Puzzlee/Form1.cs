//160202016 selim özaydın
//160202027 kübra yıldırım

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Timers;

namespace Puzzlee
{
    public partial class Puzzlee : Form
    {
        private List<Button> buttonList = new List<Button>();
        private Image[] imgarray = new Image[16];
        private List<int> randomList = new List<int>();
        private String path = "";
        private Boolean control = false;
        private ArrayList skor = new ArrayList();

        public Puzzlee()
        {
            InitializeComponent();
            dosyaOku();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private DateTime time = new DateTime(0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            label1.Text = time.ToLongTimeString();
        }

        private int k = 0;
        private void dosyaYaz(ArrayList skor)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\selim\\Desktop\\enyüksekskor.txt");
            try
            {
                while (k < skor.Count)
                {
                    //sw.WriteLine((k+1) + ". " + skor[k]);
                    sw.WriteLine(skor[k]);
                    k++;
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void dosyaOku()
        {
            try
            {
                StreamReader sr = File.OpenText("C:\\Users\\selim\\Desktop\\enyüksekskor.txt");
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    skor.Add(Convert.ToInt32(line));
                }
                skor.Sort();
                skor.Reverse();
                label2.Text = ("En yüksek skor\n" + "          " + skor[0]);
                sr.Close();
                int j = 0;
                while (j < skor.Count)
                {
                    Console.WriteLine(skor[j]);
                    j++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        private void resimGetir()
        {
            try 
            {
                var img = Image.FromFile(path);
                img = (Image)(new Bitmap(img, new Size(600, 600)));
                
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                      var index = i * 4 + j;
                       imgarray[index] = new Bitmap(150, 150);
                       var graphics = Graphics.FromImage(imgarray[index]);
                       graphics.DrawImage(img, new Rectangle(0, 0, 150, 150), new Rectangle(j*150, i*150, 150, 150), GraphicsUnit.Pixel);
                       graphics.Dispose();
                    }
                }
                control = true;
                button17.Enabled = true;
                for (int i = 0; i < 16; i++) 
                {
                    buttonList[i].Enabled = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            buttonList.Add(button1);
            buttonList.Add(button2);
            buttonList.Add(button3);
            buttonList.Add(button4);
            buttonList.Add(button5);
            buttonList.Add(button6);
            buttonList.Add(button7);
            buttonList.Add(button8);
            buttonList.Add(button9);
            buttonList.Add(button10);
            buttonList.Add(button11);
            buttonList.Add(button12);
            buttonList.Add(button13);
            buttonList.Add(button14);
            buttonList.Add(button15);
            buttonList.Add(button16);
        }


        private int Click_Counter = 0;
        public List<int> clickArray = new List<int>();
        private void  button1_Click(object sender, EventArgs e)
        {
            Click_Counter++;
            clickArray.Add(0);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();
            }
        }
        private void  button2_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(1);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void  button3_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(2);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void  button4_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(3);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void  button5_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(4);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void  button6_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(5);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void  button7_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(6);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void  button8_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(7);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void  button9_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(8);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(9);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(10);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void button12_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(11);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void button13_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(12);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void button14_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(13);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void button15_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(14);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();

            }
        }
        private void button16_Click(object sender, EventArgs e)
        {

            Click_Counter++;
            clickArray.Add(15);
            if (Click_Counter == 2)
            {
                Image temp = buttonList[clickArray[0]].BackgroundImage;
                buttonList[clickArray[0]].BackgroundImage = buttonList[clickArray[1]].BackgroundImage;
                buttonList[clickArray[1]].BackgroundImage = temp;
                Click_Counter = 0;
                clickArray.Clear();
            }
        }

        
        private void  button1_MauseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(120, 130);
        }
        private void  button1_MauseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(112, 122);
        }
        private void  button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Size = new Size(120, 130);
        }
        private void  button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(112, 122);
        }
        private void  button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Size = new Size(120, 130);
        }
        private void  button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(112, 122);
        }
        private void  button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Size = new Size(120, 130);
        }
        private void  button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(112, 122);
        }
        private void  button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Size = new Size(120, 130);
        }
        private void  button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Size = new Size(112, 122);
        }
        private void  button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Size = new Size(120, 130);
        }
        private void  button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Size = new Size(112, 122);
        }
        private void  button7_MouseEnter(object sender, EventArgs e)
        {
            button7.Size = new Size(117, 127);
        }
        private void  button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Size = new Size(112, 122);
        }
        private void  button8_MouseEnter(object sender, EventArgs e)
        {
            button8.Size = new Size(120, 130);
        }
        private void  button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Size = new Size(112, 122);
        }
        private void  button9_MouseEnter(object sender, EventArgs e)
        {
            button9.Size = new Size(120, 130);
        }
        private void  button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Size = new Size(112, 122);
        }
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.Size = new Size(120, 130);
        }
        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Size = new Size(112, 122);
        }
        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.Size = new Size(120, 130);
        }
        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Size = new Size(112, 122);
        }
        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.Size = new Size(120, 130);
        }
        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.Size = new Size(112, 122);
        }
        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.Size = new Size(120, 130);
        }
        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Size = new Size(112, 122);
        }
        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.Size = new Size(120, 130);
        }
        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.Size = new Size(112, 122);
        }
        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.Size = new Size(120, 130);
        }
        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.Size = new Size(112, 122);
        }
        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.Size = new Size(120, 130);
        }
        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.Size = new Size(112, 122);
        }


        private void karıstır() 
        {
            int dogruSayisi = 0;
            timer1.Enabled = false;
            timer1.Enabled = true;
            time = new DateTime(0);
            
            Random rastgele = new Random();
            int sayi = 0;
            randomList.Clear();
            for (int i = 0; i < 16; i++)
            {
                sayi = rastgele.Next(0, 16);
                if (!randomList.Contains(sayi))
                {
                    randomList.Add(sayi);
                    buttonList[i].BackgroundImage = imgarray[sayi];
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 16; i++)
            {
                if (CompareImage(buttonList[i].BackgroundImage, imgarray[i]))
                {
                    dogruSayisi++;
                }
            }
            if (dogruSayisi > 0)
            {
                //MessageBox.Show("En az bir parça doğru yerde oyuna başlayabilirsiniz.");
                button17.Enabled = false;
                if (dogruSayisi == 16)
                {
                    MessageBox.Show("Tebrikler !! 100 puan");
                    bitir();
                }
            }
            else
                MessageBox.Show("Tekrar karıştırınız.");

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (control == true)
            {
                karıstır();
            }
        }
        
        private void button18_Click_1(object sender, EventArgs e)
        {
            skor.Sort();
            skor.Reverse();
            dosyaYaz(skor);
            this.Close();
            //Application.Exit();
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\Users\\selim\\Desktop\\Image.File";
            file.Filter = "Resim |*.png| Resim|*.jpg| Resim|*.jpeg| Resim|*.bmp";
            file.FilterIndex = 2;
            file.ShowDialog();

            path = file.FileName;
            Console.WriteLine(path);
            resimGetir();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bitir();
        }

        private void bitir()
        {
            timer1.Enabled = false;
            String[] s = label1.Text.Split(':');
            int saniye = Convert.ToInt32(s[2]);
            int dakika = Convert.ToInt32(s[1]);
            int dogruParcaSayisi = 0;

            for (int i = 0; i < 16; i++)
            {
                if (CompareImage(buttonList[i].BackgroundImage, imgarray[i]))
                {
                    dogruParcaSayisi++;
                }
            }
            if (dogruParcaSayisi == 16)
            {
                if (dakika == 0)
                {
                    MessageBox.Show("Tebrikler !! 100 puan\nSüre:" + label1.Text);
                    skorEkle(100);
                }
                if (dakika == 1)
                {
                    MessageBox.Show("Tebrikler !! 95 puan\nSüre:" + label1.Text);
                    skorEkle(95);
                }
                if (dakika == 2)
                {
                    MessageBox.Show("Tebrikler !! 90 puan\nSüre:" + label1.Text);
                    skorEkle(90);
                }
                if (dakika == 3)
                {
                    MessageBox.Show("Tebrikler !! 85 puan\nSüre:" + label1.Text);
                    skorEkle(85);
                }
                if (dakika == 4)
                {
                    MessageBox.Show("Tebrikler !! 80 puan\nSüre:" + label1.Text);
                    skorEkle(80);
                }
            }
            else
            {
                if (dakika == 0)
                {
                    MessageBox.Show("Puzzle'ı tamamlayamadınız !!" + ((dogruParcaSayisi * 5) + 20) + " puan\nSüre:" + label1.Text);
                    skorEkle(dogruParcaSayisi * 5 + 20);
                }
                if (dakika == 1)
                {
                    MessageBox.Show("Puzzle'ı tamamlayamadınız !!" + ((dogruParcaSayisi * 5) + 15) + " puan\nSüre:" + label1.Text);
                    skorEkle(dogruParcaSayisi * 5 + 15);
                }
                if (dakika == 2)
                {
                    MessageBox.Show("Puzzle'ı tamamlayamadınız !!" + ((dogruParcaSayisi * 5) + 10) + " puan\nSüre:" + label1.Text);
                    skor.Add(dogruParcaSayisi * 5 + 10);
                }
                if (dakika == 3)
                {
                    MessageBox.Show("Puzzle'ı tamamlayamadınız !!" + ((dogruParcaSayisi * 5) + 5) + " puan\nSüre:" + label1.Text);
                    skorEkle(dogruParcaSayisi * 5 + 5);
                }
                if (dakika == 4)
                {
                    MessageBox.Show("Puzzle'ı tamamlayamadınız !!" + (dogruParcaSayisi * 5) + " puan\nSüre:" + label1.Text);
                    skorEkle(dogruParcaSayisi * 5);
                }
            }

            for (int i = 0; i < 16; i++)
            {
                buttonList[i].Enabled = false;
            }
        }

        private void skorEkle(int skor1)
        {
            skor.Add(skor1);
        }


        private Bitmap img1, img2;
        public bool CompareImage(Image resim1, Image resim2)
        {
            img1 = new Bitmap(resim1);
            img2 = new Bitmap(resim2);

            string imgS1, imgS2;

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    imgS1 = img1.GetPixel(i, j).ToString();
                    imgS2 = img2.GetPixel(i, j).ToString();

                    if (imgS1 != imgS2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}