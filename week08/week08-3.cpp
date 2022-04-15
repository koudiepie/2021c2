#include <stdio.h>
int main()
{
    FILE*f=fopen("檔案輸出.txt", "w+");
    fprintf(f,"Hello我在這裡喔\n" );
}
