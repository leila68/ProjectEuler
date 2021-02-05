//
// Created by Leila on 2/5/2021.
//

#ifndef PROBLEM2_FIBONACCI_H
#define PROBLEM2_FIBONACCI_H


class Fibonacci {
    int S=1;
    int P=0;
    int F=0;
    int sum=0;
public:
    Fibonacci();
    ~Fibonacci();


    int Fibo();

    Fibonacci(Fibonacci *pFibonacci);
};


#endif //PROBLEM2_FIBONACCI_H
