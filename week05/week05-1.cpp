#include <stdio.h>
int a[10]={9,8,7,1,2,3,6,5,4,0};
int main()
{
    for(int i=0;i<10;i++){
        for(int j=i;j<10;j++){
            if(a[i]>a[j]){
                int temp=a[i];
                a[i]=a[j];
                a[j]=temp;
            }
        }
    }
}

