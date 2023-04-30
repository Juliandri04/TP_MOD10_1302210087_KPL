using AljabarLibraries;

double[] akarpersamaan = { 1, -3, -10 };
double[] hasil = { 2, -3 };

double[] AkarPersamaanKuadrat = QuadraticForm.AkarPersamaanKuadrat(akarpersamaan);
double[] HasilKuadrat = QuadraticForm.HasilKuadrat(hasil);

Console.WriteLine("{" + AkarPersamaanKuadrat[0] + ", " + AkarPersamaanKuadrat[1] + "}");
Console.WriteLine("{" + HasilKuadrat[0] + ", " + HasilKuadrat[1] + ", " + HasilKuadrat[2] + "}");
