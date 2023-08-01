string[] NewReadLine(){
    Console.WriteLine("Введите ваши слова одной строкой : ");
    string stroka = Console.ReadLine()! ;
    string[] words = stroka.Split(' ') ;
    Console.WriteLine("Введенные слова : ");
    Console.Write("[“");
    Console.Write(String.Join("”, “", words));
    Console.WriteLine("”]");
    return words;
}
string[] Cutter(string[] words){
    int j = 0 ;
    string[] CuttedWords = new string[words.Length]; 
    for (int i = 0 ; i < words.Length ; i++ ){
        if(words[i].Length <= 3){
            CuttedWords[j] = words[i];
            j++;
        }
    }
    Array.Resize(ref CuttedWords, j);
    return(CuttedWords);
}
void NewOutputLine(string[] words){
    Console.WriteLine("Слова, длина которых меньше, либо равна 3 символам: ");
    if(words.Length > 0 ){
        Console.Write("[“");
        Console.Write(String.Join("”, “", words)!);
        Console.WriteLine("”]");
    }else{
        Console.Write("Все слова длиннее 3 символов");    
    }
}

NewOutputLine(Cutter(NewReadLine()));