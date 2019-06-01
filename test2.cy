fun count_down(num) {
    print(num);
    if (num > 0) {
        count_down(num - 1);
    };
};

count_down(10);