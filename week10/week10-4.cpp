#include <stdio.h>
#include <vector>
#include <algorithm>
class Record{
public:
    char name[30];
    int grade;
};
bool compare(Record a,Record b){
    return(a.grade>b.grade);
}
int main()
{
    FILE * fin=fopen("input.txt","r");
    int n;
    fscanf(fin,"%d",&n);
    std::vector<Record> student(20);
    for(int i=0;i<n;i++){
        fscanf(fin,"%s %d",student[i].name,&student[i].grade);
    }
    std::sort(student.begin(),student.end(),compare);
    for(int i=0;i<n;i++){
        printf("%s %d\n",student[i].name,student[i].grade);
    }
}

