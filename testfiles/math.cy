print(-24_200);
print(-1 * 2);
print(0 + -1);

int a = 12;
print(-a);

int b = a * -1;
print(b / 12);

print(2 + 3 * 4);
print((2 + 3) * 4);

//print(400 / -0);

fun fib(n) {
    if (n == 0) {
        0;
    } else if(n == 1) {
        1;
    } else {
        fib(n-1) + fib(n-2);
    };
};

print(fib(6));