//
// Created by Leila on 2/5/2021.
//

#include "Fibonacci.h"
#include <iostream>
Fibonacci::Fibonacci()
{

}
Fibonacci::~Fibonacci()
{

}
int Fibonacci::Fibo()
{
    std::cout<< P <<"\t";
    std::cout<< S <<"\t";
    do
    {
        if (S % 2 == 0) {
            sum = sum + S;
        }
        F=P+S;
        std::cout<< F <<"\t";
        P=S;
        S=F;


    } while (F<4000000);
    return sum;
}

Fibonacci::Fibonacci(Fibonacci *pFibonacci) {

}
