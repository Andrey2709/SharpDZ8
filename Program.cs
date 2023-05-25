

// задача 54========================================================
int[,] sort(int [,] a){

    int rows = a.GetUpperBound(0)+1;
    int columns = a.Length/rows;
    Boolean est = true;
     int x = 0;
     
    for(int i = 0  ; i<columns-1;i++){
       while(est)     
       est = false;
        for(int j = 0;j<columns-1; j++ ){

if(a[i,j]<a[i,j+1]){
    est  = true;
    x =  a[0,j];
    a[0,j] = a[0,j+1];
    a[0,j+1] = x;
}
        }
    }
return a;
}



int[,] arr = {{1472},{5923},{8424}}; 



// задача 56

//==========================================================================

int utilMinSum(int[]a){
int min = 0;
for(int i = 1 ;i<a.Length-1;i++){
min = a[0];
if(min>a[i]){
 min = a[i];
}
}
    return min;
};
//============================================================================
int[] utilSumsRows(int [,] a){

int rows = a.GetUpperBound(0)+1;
int columns = a.Length/rows;
int[]sumArr =new int[rows];

for(int i  = 0; i<columns-1;i++ ){
    int minSum = 0;
    int sum = 0;
        for(int j = 0 ; j<rows-1;j++){
         sum+=a[i,j] ;
    } 
    sumArr[i] = sum;
}
    return  sumArr;
};
//===================================================
int minSumRows(int [,]a ){
    return utilMinSum(utilSumsRows(a));

};

// задача 58 =============================================
int sumArr(int[] a){
    int sum= 0;
    for(int j = 0 ; j<a.Length;j++){
         sum+=a[j] ;
    } 
    return sum;
}
//=============================================================
int[,] matrixMultiplication(int[,]a,int[,] b){
    int rowsA = a.GetUpperBound(0)+1;
    int columnsA = a.Length/rowsA;

    int rowsB = b.GetUpperBound(0)+1;
    int columnsB = a.Length/rowsB;
int [,] c = new int[rowsA,columnsA];
    Console.WriteLine(columnsA);
    int sum= 0;
int [] x = new int[rowsB];
for(int t = 0 ; t<columnsA;t++){
    for(int i = 0 ; i<rowsA;i++){
         for(int j = 0 ; j<rowsB;j++){
            x[j] = b[t,i]*a[i,j];
         }
        
sum = sumArr(x);
Console.WriteLine("sum ="+sum);
c[t,i] = sum;
    }
}
return c;
}

int[,] b = new int[2,2]{{3,4},
                        {3,3}};
int[,] a = new int[2,2]{{2,4},
                        {3,2}};
matrixMultiplication(a,b);



void threeMerArr(){
    Random random = new Random();
int[,,] arr = new int[2,2,2];
for(int i= 0; i<2;i++){
    for(int j= 0; j<2;j++){
        for(int o= 0; o<2;o++){
            arr[i,j,o] = random.Next(10,99);
            Console.Write(arr[i,j,o]+"("+i+","+j+","+o+")"+" ");

}
   
}
}
};

threeMerArr();