#include <iostream>
#include <vector>
char name[100][30];
int grade[100];
int main()
{
	int n;
	std::cin>>n;
	for(int i=0;i<n;i++){
		std::cin>>name[i]>>grade[i];
	}
	for(int i=0;i<n;i++){
		std::cout<<name[i]<<std::endl;
	}
}
