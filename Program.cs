Random dice = new Random();

int roll = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int total = roll + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll}  + {roll2} + {roll3} = {total}");
int vezesQueGanhou = 0 ;
int vezesQuePerdeu = 0 ;
Console.Write("Quantas vezes você quer jogar?");

int quantidadeQueQuerJogar = Int32.Parse( Console.ReadLine());
if(quantidadeQueQuerJogar == null){

    Console.WriteLine("Espaço não pode ser vazio!");
}


int x = 0;
while(x < quantidadeQueQuerJogar){

if (total > 14 ) {
    Console.WriteLine("Você ganhou!");
    vezesQueGanhou ++; 
    x ++;
}

else if (total < 15){
    Console.WriteLine("Você perdeu!");
    vezesQuePerdeu ++;
    x ++;
}
}
Console.WriteLine($"vezes Que Ganhou: {vezesQueGanhou}");
Console.WriteLine($"vezes Que Perdeu: {vezesQuePerdeu}");
