// See https://aka.ms/new-console-template for more information 



//  ------------------------------------------------------



//  ------------------------------------------------------



void zadach1(){
    int[] mas = new int [] {20,3,24,76,66,11,36,07,30,73};
    int min =  mas [0];
    foreach (int E in mas)
    {
        if (min > E)
        {
            min = E;
        }
    }
    mas [mas.Length - 1] = min; 
    Console.WriteLine(min);

}

void zadach2(){
  int getMin ( int a, int b){
    if (a<b){
        return b;
    }
        return a;
}
        int a = 1;
        int b = 2;
        int c = 3;
        int d = 4;
        int min1= getMin(a,b);
        int min2= getMin(c,d);
        Console.WriteLine(getMin(min1,min2));  
}
void zadach3(){
    char[] Eroor=new char[]{'!','-',',','_','.',';',':'};
    string[] ustal = new string[]{"МДК!","Слово","Смысл!","Жизнь","Земля","Планета!","Красота","Округ!","Система!","Игорь!",
    "САО","Продуктивность!","Орёл","Донецк!","Это!","Не бойся","***","-Боль","А","С"};
    int calc(String str) {
        int result=0;

        foreach (char Prepin in str){
        if (Eroor.Contains(Prepin)) {
            result++;
        }         
        }

        return result;
    }

    int result = 0;
    foreach (string str in ustal){
        Console.WriteLine("{0}:{1}",str,calc(str));
        result+=calc(str);
    }

    Console.WriteLine(result);
}