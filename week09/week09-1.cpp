#include <stdio.h>
int grade[10]={9,8,1,2,3,7,6,4,5,0};
int main()
{
    int n=10;
    for(int k=0;k<n-1;k++){
        for(int i=0;i<n-1;i++){
            if(grade[i]>grade[i+1]){
                int temp=grade[i];
                grade[i]=grade[i+1];
                grade[i+1]=temp;
            }
        }
        for(int i=0;i<n;i++) printf("%d",grade[i]);
            printf("\n");
    }
}
