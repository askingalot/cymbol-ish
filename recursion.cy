fun count_down(num) {
    print(num);
    if (num > 0) {
        count_down(num - 1);
    };
};

fun count_up(num) {
    print(num);
    count_up(num + 1);
};