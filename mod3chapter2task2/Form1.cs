namespace mod3chapter2task2
{
    public partial class Form1 : Form
    {
        private List<ProgressBar> horses;
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            horses = new List<ProgressBar>() { pbHorse1, pbHorse2, pbHorse3, pbHorse4, pbHorse5 };

            dgvResults.Columns.Add("Horse", "Кінь");
            dgvResults.Columns.Add("Time", "Час");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            cts = new CancellationTokenSource();

            try
            {
                List<Task<double>> tasks = new List<Task<double>>();

                for (int i = 0; i < horses.Count; i++)
                {
                    int horseNumber = i + 1;
                    tasks.Add(Task.Run(() => RunHorse(horseNumber, cts.Token)));
                }

                double[] results = await Task.WhenAll(tasks);

                dgvResults.Rows.Clear();

                for (int i = 0; i < results.Length; i++)
                {
                    dgvResults.Rows.Add($"Кінь {i + 1}", $"{Math.Round(results[i], 2)} секунд");
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Перегони були скасовані.");
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }

        private async Task<double> RunHorse(int horseNumber, CancellationToken ct)
        {
            Random random = new Random();
            int distance = 100;
            int position = 0;

            DateTime startTime = DateTime.Now;

            double seconds = 0;

            while (position < distance)
            {
                if (ct.IsCancellationRequested)
                {
                    throw new OperationCanceledException();
                }

                int speed = random.Next(1, 6);
                position += speed;

                if (position > distance)
                {
                    position = distance;
                }

                horses[horseNumber - 1].Value = position;

                await Task.Delay(100);

                TimeSpan elapsedTime = DateTime.Now - startTime;
                seconds = elapsedTime.TotalSeconds;
            }

            return seconds;
        }

    }
}