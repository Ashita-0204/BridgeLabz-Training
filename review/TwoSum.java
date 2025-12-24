import java.util.*;
 
 public class TwoSum{
    public static void main(String [] args){
        Scanner sc= new Scanner(System.in);
        int n=sc.nextInt();
        int [] arr= new int[n];
        for(int i=0;i<n;i++){
            arr[i]=sc.nextInt();
        }
        int target=sc.nextInt();
        meth(arr,target);
        }
        
        
        public static void meth(int [] arr, int target){
        HashMap<Integer,Integer> map = new HashMap<>();
        int idx=0,val1=0;
        for(int i=0;i<arr.length;i++){
            int ans=target-arr[i];
        if(map.containsValue(ans)){
            idx=map.get(ans);
             return; 
       }
        val1=arr[i];
    }
    System.out.print(val1 + ""+ idx);
 }} 
