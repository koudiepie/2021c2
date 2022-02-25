#include <stdio.h>
int main()
{
    printf("現在要練習讀入字元,字串:");

    char c;
    scanf("%c",&c);
    printf("讀到字元: %c\n",c);

    char line[1000];
    scanf("%s",line);
    printf("讀到字串: %s\n",line);

    return 0;
}
