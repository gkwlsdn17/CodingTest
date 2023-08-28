# 어떠한 수 N이 1이 될 때 까지 다음의 두 과정 중 하나를 반복적으로 선택하여 수행하려고 한다.
# 단, 두번째 연산은 N이 K로 나누어떨어질 때만 선택할 수 있다.

# 1. N에서 1을 뺀다.
# 2. N을 K로 나눈다.

def solution(value):
    n, k = list(map(int, value.split(" ")))
    cnt = 0
    while True:
        if n == 1:
            break
        cnt += 1
        if n % k == 0:
            n = n / k
        else:
            n = n - 1
    
    print(cnt)


if __name__ == "__main__":
    value = "25 5"
    solution(value)