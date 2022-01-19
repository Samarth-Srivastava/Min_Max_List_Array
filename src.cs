using System;
using System.IO;
using System.Collections.Generic;

class MAIN  {
    public static void Main(string[] args) {
        
        MAIN m = new MAIN();

        string line = Console.ReadLine();
        string[] n_arr_str = line.Split(' ');
        
        int N = Convert.ToInt32(n_arr_str[0]);
        
        List<int> A = new List<int>();
        for(int i = 0; i < N; i++){
            A.Add(Convert.ToInt32(n_arr_str[i+1]));
        }
        
        Console.WriteLine(m.max(A, N) + " " + m.min(A, N));

    }

    public int min(List<int> arr, int size){
        int min = arr[0];
        for(int i = 0; i < size; i++){
            if(arr[i] < min){
                min = arr[i];
            }
        }
        return min;
    }

    public int max(List<int> arr, int size){
        int max = arr[0];
        for(int i = 0; i < size; i++){
            if(arr[i] > max){
                max = arr[i];
            }
        }
        return max;
    }
}
