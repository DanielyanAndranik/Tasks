#include <iostream>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

int main(int argc, char**argv)
{
    int n1, n2, n3, n4;
    FILE *f1, *f2;
    
    if ((f1 = fopen(argv[1], "r")) == NULL){
        printf("Error! opening file");
        exit(1);
    }
    if ((f2 = fopen(argv[2], "w")) == NULL){
        printf("Error! opening file");
        exit(1);
    }
    
    scanf("%d %d %d %d", &n1, &n2, &n3, &n4);
    fseek(f1, n1, SEEK_SET);
    char *ptr;
    for (int i = n1; i < n2; i++) {
        
        fread(ptr, 1, 1, f1); 
        fwrite(ptr, 1, 1, f2);
        fseek(f1, 1, SEEK_CUR);
    }
    
    fseek(f1, n3, SEEK_SET);
    for (int i = n3; i < n4; i++) {
        
        fread(ptr, 1, 1, f1); 
        fwrite(ptr, 1, 1, f2);
        fseek(f1, 1, SEEK_CUR);
    }
    
    fclose(f1);
    fclose(f2);
    
}
