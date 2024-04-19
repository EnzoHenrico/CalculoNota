float grade1;
float grade2;
float gradeAverage;

Console.Write("Digite a primeira nota: ");
grade1 = float.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
grade2 = float.Parse(Console.ReadLine());

if (grade1 < 0 || grade2 < 0)
{
    Console.WriteLine("As notas devem ter um valor maior que 0 ");
}
else
{
    gradeAverage = (grade1 + grade2) / 2;
    if (gradeAverage <= 3)
    {
        Console.WriteLine($"Média {gradeAverage} -> Aluno reprovado.");
    }
    else
    {
        if (gradeAverage <= 5) 
        {
            Console.WriteLine($"Média {gradeAverage} -> Aluno de exame.");
        }
        else
        {
            Console.WriteLine($"Média {gradeAverage} -> Aluno aprovado.");
        }
    }
}