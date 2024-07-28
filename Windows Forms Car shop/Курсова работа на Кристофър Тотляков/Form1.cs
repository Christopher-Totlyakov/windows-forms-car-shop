using System.Reflection;
using static Курсова_работа_на_Кристофър_Тотляков.Form1;

namespace Курсова_работа_на_Кристофър_Тотляков
{
    public partial class Form1 : Form
    {
        bool gridExpand = false;

        public class Car
        {
            private string RegistrationNumber { get; }
            private string Brand { get; }
            private string Model { get; }
            private int Year { get; }
            private int Horsepower { get; }

            public Car(string registrationNumber, string brand, string model, int year, int horsepower)
            {
                RegistrationNumber = registrationNumber;
                Brand = brand;
                Model = model;
                Year = year;
                Horsepower = horsepower;
            }

            public (string, string, int) SearchBrandModelYear()
            {
                return (Brand, Model, Year);
            }

            public string GetRegistrationNumber()
            {
                return RegistrationNumber;
            }
            public (string, int) SearchBrandHorsepower()
            {
                return (Brand, Horsepower);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            buttonSave.Visible = false;
            carPictureBox.Visible = false;

            dataGridView1.RowHeadersVisible = false;

            yearsLabel.Visible = false;
            brandLabel.Visible = false;
            modelLabel.Visible = false;
            yearsTextBox.Visible = false;
            brandTextBox.Visible = false;
            modelTextBox.Visible = false;
            filterFindButton.Visible = false;
            carFilterlabel.Visible = false;
            carListBox.Visible = false;

            VisibilityFilterHorsepower(false);


        }


        private void gridTransiton_Tick(object sender, EventArgs e)
        {

            if (gridExpand)
            {
                topBar.Height -= 100;
                if (topBar.Height <= 50)
                {
                    gridExpand = false;
                    gridTransition.Stop();
                }
            }
            else
            {
                topBar.Height += 100;
                if (topBar.Height >= 250)
                {
                    gridExpand = true;
                    gridTransition.Stop();
                }
            }

        }

        private void gridButten_Click(object sender, EventArgs e)
        {
            gridTransition.Start();
            gridButten1.Visible = false;
            gridButten2.Visible = true;
            gridLabal.Visible = false;
            carLogopictureBox.Visible = true;


            loadedDataButton.Visible = true;
            yearsLabel.Visible = false;
            brandLabel.Visible = false;
            modelLabel.Visible = false;
            yearsTextBox.Visible = false;
            brandTextBox.Visible = false;
            modelTextBox.Visible = false;
            filterFindButton.Visible = false;
            carFilterlabel.Visible = false;
            carListBox.Visible = false;

            titleLabel1.Visible = false;
            titleLabel2.Visible = false;
            tirePictureBox.Visible = false;

            VisibilityFilterHorsepower(false);
        }

        private void gridButten2_Click(object sender, EventArgs e)
        {
            gridTransition.Start();
            gridButten2.Visible = false;
            gridButten1.Visible = true;
            gridLabal.Visible = true;
            loadedDataButton.Visible = false;
            dataGridView1.Visible = false;
            buttonSave.Visible = false;
            carPictureBox.Visible = false;

            carLogopictureBox.Visible = true;
            TitleDelay();

        }
        private async void TitleDelay()
        {
            await Task.Delay(400);
            titleLabel1.Visible = true;
            titleLabel2.Visible = true;
            tirePictureBox.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:\\Users\\User\\Desktop\\Windows Forms Car shop\\data.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter fileData = new StreamWriter(fileStream);

            List<string> data = new List<string>();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                data.Clear();
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    
                    if (dataGridView1[j, i].Value == null)
                    {
                        continue;
                    }
                    data.Add(dataGridView1[j, i].Value.ToString());
                }
                if (data.Count == 5)
                {
                    if (i != 0)
                    {
                        fileData.Write("\n");
                    }
                    fileData.Write(string.Join(" ", data));
                }
            }
            fileData.Close();
            loadedDataButton_Click(sender, e);
        }

        private void loadedDataButton_Click(object sender, EventArgs e)
        {
            carLogopictureBox.Visible = false;
            dataGridView1.Rows.Clear();


            loadedDataButton.Visible = false;
            dataGridView1.Visible = true;
            buttonSave.Visible = true;
            StreamReader fileData = new StreamReader("C:\\Users\\User\\Desktop\\Windows Forms Car shop\\data.txt");
            string dataLine = fileData.ReadLine();
            int n = 0;
            while (dataLine != null)
            {

                dataGridView1.Rows.Add();

                string[] data = dataLine.Split(" ");
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1[i, n].Value = data[i];
                }
                n++;

                dataLine = fileData.ReadLine();
            }
            fileData.Close();
            dataGridView1[0, 0].Selected = false;
        }

        private void gridLabal_Click(object sender, EventArgs e)
        {
            gridButten_Click(sender, e);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            VisibilityFilterHorsepower(false);
            if (topBar.Height >= 250)
            {
                gridTransition.Start();
                gridButten2.Visible = false;
                gridButten1.Visible = true;
                gridLabal.Visible = true;
                loadedDataButton.Visible = true;
                dataGridView1.Visible = false;
                buttonSave.Visible = false;
            }

            VisibilityDelay(true, 400);
            titleLabel1.Visible = false;
            titleLabel2.Visible = false;
            tirePictureBox.Visible = false;
        }
        private async void VisibilityDelay(bool flag, int delay)
        {
            await Task.Delay(delay);
            yearsLabel.Visible = flag;
            brandLabel.Visible = flag;
            modelLabel.Visible = flag;
            yearsTextBox.Visible = flag;
            brandTextBox.Visible = flag;
            modelTextBox.Visible = flag;
            filterFindButton.Visible = flag;
            carFilterlabel.Visible = flag;
            carPictureBox.Visible = flag;

        }

        private void filterFindButton_Click(object sender, EventArgs e)
        {
            carListBox.Visible = false;
            carListBox.Items.Clear();

            int.TryParse(yearsTextBox.Text, out int inputYear);
            string inputBrand = brandTextBox.Text;
            string inputModel = modelTextBox.Text;

            List<Car> filteredCars = new List<Car>();

            loadedDataButton_Click(sender, e);
            loadedDataButton.Visible = true;
            dataGridView1.Visible = false;
            buttonSave.Visible = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string regNumber = row.Cells["Column1"].Value?.ToString();
                string brand = row.Cells["Column2"].Value?.ToString();
                string model = row.Cells["Column3"].Value?.ToString();
                int.TryParse(row.Cells["Column4"].Value?.ToString(), out int year);
                int.TryParse(row.Cells["Column5"].Value?.ToString(), out int horsepower);

                Car car = new Car(regNumber, brand, model, year, horsepower);
                filteredCars.Add(car);

            }

            foreach (Car car in filteredCars)
            {
                int currentYear = DateTime.Now.Year;
                (string brand, string model, int year) = car.SearchBrandModelYear();

                bool brandAndModelMatch = (string.IsNullOrWhiteSpace(inputBrand) || brand == inputBrand) &&
                           (string.IsNullOrWhiteSpace(inputModel) || model == inputModel);
                bool yearMatch = inputYear == 0 || currentYear - year <= inputYear;
               


                if (brandAndModelMatch && yearMatch)
                {
                    carListBox.Items.Add(car.GetRegistrationNumber());
                }
            }
            if (carListBox.Items.Count == 0)
            {
                MessageBox.Show("Не е наличен такъв автомобил.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            carListBox.Visible = true;

        }

        private void filterHorsepowerButton_Click(object sender, EventArgs e)
        {
            if (topBar.Height >= 250)
            {
                gridTransition.Start();
                gridButten2.Visible = false;
                gridButten1.Visible = true;
                gridLabal.Visible = true;
                loadedDataButton.Visible = true;
                dataGridView1.Visible = false;
                buttonSave.Visible = false;
            }
            VisibilityDelay(false, 0);
            VisibilityDelayOnFilterHorsepower();
            titleLabel1.Visible = false;
            titleLabel2.Visible = false;
            tirePictureBox.Visible = false;
            carListBox.Visible = false;


        }
        private async void VisibilityDelayOnFilterHorsepower()
        {
            await Task.Delay(400);

            VisibilityFilterHorsepower(true);
            horsepowerlistBox.Visible = false;
        }
        private void VisibilityFilterHorsepower(bool flag) 
        {
            minHorsepowerLabel.Visible = flag;
            minHorsepowerTextBox.Visible = flag;
            maxHorsepowerLabel.Visible = flag;
            maxHorsepowerTextBox.Visible = flag;
            horsepowerLabel.Visible = flag;
            brandHorsepowerlabel.Visible = flag;
            filterByHorsepowerlabelTitle.Visible = flag;
            brandHorsepowerTextBox.Visible = flag;
            horsepowerlistBox.Visible = flag;
            findHorsepowerbutton.Visible = flag;
            carPictureBox.Visible = flag;
        }

        private void findHorsepowerbutton_Click(object sender, EventArgs e)
        {
            List<Car> filteredCars = new List<Car>();

            horsepowerlistBox.Items.Clear();
            loadedDataButton_Click(sender, e);
            loadedDataButton.Visible = true;
            dataGridView1.Visible = false;
            buttonSave.Visible = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string regNumber = row.Cells["Column1"].Value?.ToString();
                string brand = row.Cells["Column2"].Value?.ToString();
                string model = row.Cells["Column3"].Value?.ToString();
                int.TryParse(row.Cells["Column4"].Value?.ToString(), out int year);
                int.TryParse(row.Cells["Column5"].Value?.ToString(), out int horsepower);

                Car car = new Car(regNumber, brand, model, year, horsepower);
                filteredCars.Add(car);
            }

            foreach (Car car in filteredCars)
            {//kortej
                (string brand, int horsepower) = car.SearchBrandHorsepower();


                
                
                string inputBrand = brandHorsepowerTextBox.Text;
                int.TryParse(minHorsepowerTextBox.Text, out int minHorsepower);
                int.TryParse(maxHorsepowerTextBox.Text, out int maxHorsepower);
                if (maxHorsepowerTextBox.Text == "")
                {
                    maxHorsepower = 999;
                }

                bool horsepowerMatch = (minHorsepower <= horsepower) &&
                           (maxHorsepower >= horsepower);

                bool brandMatch = brand == inputBrand || string.IsNullOrWhiteSpace(inputBrand);


                if (horsepowerMatch && brandMatch)
                {
                    horsepowerlistBox.Items.Add(car.GetRegistrationNumber());
                }
            }
            if (horsepowerlistBox.Items.Count == 0)
            {
                horsepowerlistBox.Visible = false;
                MessageBox.Show("Не е наличен такъв автомобил.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            horsepowerlistBox.Visible = true;
        }
    }
}
