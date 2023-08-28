def solution(array, n, m, k):
    array.sort()
    a = m // (k+1)
    b = m % (k+1)

    answer = ((k+1) * array[-1] * a) - (a * array[-1]) + (a * array[-2]) + (b * array[-1])

    print(answer)


if __name__ == '__main__':

    # 어떤 배열이 있을 때, 주어진 수들을 m번 더하여 가장 큰 수를 만드는 방법.
    # 단, 배열의 특정한 인덱스(번호)에 해당하는 수가 연속해서 k번을 초과하여 더해질수 없음
    # n은 배열의 크기
    array = [2,4,5,4,6]

    n = len(array)
    m = 8
    k = 3

    solution(array, n, m, k)