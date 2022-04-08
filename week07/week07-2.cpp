#include <stdio.h>
#include <stdlib.h>
#include <string.h>
char line[1000][20];
int compare(const void *p1,const void *p2)
{
    char * s1 = (char*) p1;
    char * s2 = (char*) p2;
    return strcmp(s1,s2);
}
int main()
{
    int n;
    scanf("%d\n",&n);
    for(int i=0;i<n;i++){
        gets(line[i]);
    }
    qsort(line,n,20,compare);
    for(int i=0;i<n;i++){
        printf("%s\n",line[i]);
    }
}

