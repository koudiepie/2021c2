#include <stdio.h>
#include <stdlib.h>
#include <string.h>
char nation[2000][80];
int compare(const void*p1,const void*p2)
{
	return strcmp((char*)p1,(char*)p2);
}
int main()
{
	int n;
	scanf("%d",&n);
	for(int i=0;i<n;i++)
	{
		scanf("%s",&nation[i]);
		char name[80];
		gets(name);
	}
	qsort(nation,n,80,compare);
	nation[n][0]=0;
	int combo=1;
	for(int i=0;i<n;i++){
		if(strcmp(nation[i],nation[i+1])==0){
			combo++;
		}
		else{
			printf("%s %d\n",nation[i],combo);
			combo=1;
		}
	}
}
