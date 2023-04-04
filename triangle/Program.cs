while (1 < 2) 
{
    Console.WriteLine("Введите размер треугольника");
    var storona = Convert.ToInt32(Console.ReadLine());
    var simbol = Console.ReadLine();
    var simbolFillNo = Console.ReadLine();
    //Int32.Parse(Console.ReadLine());
    var simbolCount = 0;
    var simbolCountMin= 0;
    var simbolCountMax= 0;

    var counter = 0;
    var storonaStop = 0; 
    for (var j = 1; j < storona; j++)
    {
        simbolCount = (storona / 2) - j + 1;
        simbolCountMin = (storona / 2) - j + 1;
        simbolCountMax = simbolCount + j;

        for (; counter < simbolCountMin; counter++)
        {
            Console.Write(simbolFillNo);
        }

        var gran = simbolCountMax + (simbolCountMax - counter - 1);
        for (; counter < gran; counter++)
        {
            Console.Write(simbol);
            storonaStop++;
            if (storona == storonaStop)
            {
                j = storona;
            }
        }

        for (; counter < storona + 1; counter++)
        {
            Console.Write(simbolFillNo);
        }
        storonaStop = 0;
        counter = 0;
        Console.WriteLine();

    }
}