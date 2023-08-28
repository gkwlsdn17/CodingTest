# n x m으로 이루어진 카드 중 어떤 행을 선택하고 가장 숫자가 낮은 카드를 뽑는데,
# 가장 숫자가 낮은 카드 중 가장 높은 숫자를 가진사람이 이기는 게임

def solution(value):
    array = value.split("\n")
    n, m = array[0].split(" ")
    card = ""
    for i in range(1, len(array)):
        number = array[i].split(" ")
        if min(number) > card:
            card = min(number)

    print(card)


if __name__ == "__main__":

    # 첫째줄은 n m
    # 둘째줄부터는 카드
    # 공백으로 구분
    send_value = "3 3\n3 1 2\n4 1 4\n2 2 2"
    solution(send_value)

    send_value = "2 4\n7 3 1 8\n3 3 3 4"
    solution(send_value)