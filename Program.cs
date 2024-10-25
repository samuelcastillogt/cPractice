int numero = 1;
void bizBuz(){
    while(numero <= 100){
        if(numero%15 == 0){
            Console.WriteLine("BizBuz");
        }else if(numero%5 == 0){
            Console.WriteLine("Buz");
        }else if(numero%3 == 0){
            Console.WriteLine("Biz");
        }else{
            Console.WriteLine(numero);
        }
        numero++;
    }
}
bizBuz();
