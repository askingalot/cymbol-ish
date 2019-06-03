fun count_down(num) {
    print(num);
    if (num > 0) {
        count_down(num - 1);
    };
};

//count_down(10);

fun count_up(num) {
    print(num);
    if (num != 200) {
        count_up(num + 1);
    };
};

count_up(0);