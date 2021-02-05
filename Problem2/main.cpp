#include <iostream>
#include "Fibonacci.h"

int main() {


    Fibonacci F1 = new Fibonacci();
    int sum = F1.Fibo();
    std::cout<<"\n"<<"sum of even-valued of fibonacci before 4m is: " << sum <<"\t";
    return 0;
}
