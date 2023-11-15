int i = 0;

for (i = 0; i < 10; i++){
    Console.WriteLine($"FOR: passou {i+1} vezes");
}

i = 0;
while (i < 10){
    Console.WriteLine($"WHILE: passou {i+1} vezes");
    i++;
}

i = 0;
do
{
    Console.WriteLine($"DO WHILE: passou {i + 1} vezes");
    i++;
} while (i < 10);