s = 'aaabbbsssaaasss'
newS = ''

























# numbers = "0123456789"
# lower_case = "abcdefghijklmnopqrstuvwxyz"
# upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
# special_characters = "!@#$%^&*()-+"
# req, other = 0, 0

# def numberz(string):
#     for x in string:
#         if x in numbers:
#             return True
#     return False

# def lowerz(string):
#     for x in string:
#         if x in lower_case:
#             return True
#     return False

# def upperz(string):
#     for x in string:
#         if x in upper_case:
#             return True
#     return False

# def specialz(string):
#     for x in string:
#         if x in special_characters:
#             return True
#     return False

# strain = 'Ab1'

# if (numberz(strain)) == False:
#     req += 1
# if (lowerz(strain)) == False:
#     req += 1
# if (upperz(strain)) == False:
#     req += 1
# if (specialz(strain)) == False:
#     req += 1
# if len(strain) < 6:
#         other = (6-len(strain))
# print(max(req, other))













# li = [[1,2,3,4,5],
#       [1,2,3,4,5],
#       [1,2,3,4,5],
#       [1,2,3,4,5],
#       [1,2,3,4,5]]
# print(len(li))
# f, s= 0,0
# k, l = len(li) -1, 0
# for i in li:
#     f += i[l]
#     s += i[k]
#     l += 1
#     k -= 1
# print(f, s)



import numpy










# from tkinter import *

# # root = Tk()
# # l = Label(root, text='hello world')
# # root.geometry('300x400')
# # l.pack()

# root.mainloop()










import string, random

class wordGame:

    def __init__(self, word):
        self.word = word.upper()

    def guess(self, letr, guesses):
        if letr in guesses: guesses = guesses.replace(letr, '')
        else: pass
        return guesses

    def check(self, letr, noOfguesses, guesses, guessed):
        if letr in self.word and len(letr) == 1: pass
        elif len(letr) != 1: pass 
        elif letr in guessed: pass
        elif letr not in string.ascii_uppercase: pass
        else: noOfguesses -= 1
        return noOfguesses

    def construct(self, guessed):
        struct = ''
        for i in self.word:
            if i in guessed: struct += i + ' '
            else: struct += '- '
        return struct
    
    def affirm(self, guessed):
        for i in self.word:
            if i not in guessed: return False
        return True

    def info(self, letr, guesses, noOfguesses):
        if letr not in string.ascii_uppercase: print('Invalid entry, enter an alphabet!')
        elif letr not in guesses: print("This letter has been guessed already, try again!")
        elif letr == '': print("You can't just enter nothing bro!")
        elif letr in self.word: print("Good guess! ")
        elif len(letr) > 1: print('Only one letter at a time bro!')
        elif noOfguesses == 0: print('You have run out of guesses, GAME OVER BRO!\nThe word was {}'.format(self.word))
        else: print("Bad guess!")
    
    def play(self):
        noOfguesses = 8
        guessed = ''
        guesses = string.ascii_uppercase
        print('A/An {}-letter word has been selected for you!'.format(len(self.word)))
        while noOfguesses > 0:
            letr = input('Enter a letter: ')
            letr = letr.upper()
            noOfguesses = self.check(letr, noOfguesses, guesses, guessed)
            if len(letr)== 1:
                guessed += letr
            print('You have {} guesses left. '.format(noOfguesses), "\n" + 'Available letters: ', ' '.join(guesses))
            print(self.construct(guessed))
            self.info(letr, guesses, noOfguesses)
            guesses = self.guess(letr, guesses)
            if self.affirm(guessed):
                print("Brava! You have guessed the word completely!")
                break

file_name = 'C:/Users/User/Desktop/coding/wordss.txt'
in_file = open(file_name,)
word_list = in_file.readline().split() 
word = random.choice(word_list)
print(word)

game = wordGame(word)
game.play()

# print('6547')



# 3524 - 3
# 2111 - 5
# 9831 - 7


    
# def kaprekarsc(num, count=1):
#     sub = '{:04}'.format(num)
#     asc, dsc = ''.join(sorted(sub)), ''.join(sorted(sub, reverse=True))
#     if int(dsc) - int(asc) == 6174: 
#         return count
#     return kaprekarsc(int(dsc) - int(asc), count+1)
# i = 0
# while True:
#     print(round(i, 3))
#     if 24/64 == round(i, 3):
#         break
#     else: i += 0.001
# print(67/89)

# j = '3741'
# print(''.join((sorted(j, reverse=True))))



# print(kaprekarsc(2897))
# print("{:04}".format(3))

# d = ''

# def cap(word):
#     new = ''
#     new = ''.join(x.upper() if word[0]==x else x for x in word)
#     # for i in word:
#     #     if i == word[0]: new += i.upper()
#     #     else: new += i
#     return new

# print(cap('jslloft'))

# def pack(word):
#     sep = word.split()
#     sep = ''.join(x.capitalize() for x in sep)
#     return sep

# # def cps(word):
# #     return word.capitalize()
# print(pack('thi s why i dont   like yiu' ))

# print(''.join(x.capitalize() for x in input('Enter sentence: ').split()))

# arr = ['a', 'b', 'a', 'c', 'c', 'a', 'b', 'a', 'c', 'c']
# for i in arr:
#     while arr.count(i) > 1:
#        arr.remove(i)
# print(arr)
# # print(arr)

# def func(arr):
#     for i in arr: 
#         if arr.count(i) == 1: pass    
#         else: arr.remove(i)
#     return func(arr)

# print(func(['a', 'b', 'a', 'c', 'c', 'a', 'b', 'a', 'c', 'c']))

# e = 1111
# n = str(e)
# print(n[0])
# a, b, c, d = int(n[0]), int(n[1]), int(n[2]), int(n[3])
# p1, p2, p3, p4 = str(sum(int(x) for x in n)), str(a*b), str(a*c), str(a*d)
# p5 = str(int(p1)+int(p2)+int(p3)+int(p4))
# l1, l2, l3, l4, l5 = ('0'+p1) if len(p1)<2 else p1, ('0'+p2) if len(p2)<2 else p2, ('0'+p3) if len(p3)<2 else p3, ('0'+p4) if len(p4)<2 else p4, ('0'+p5) if len(p5)>2 else ('00'+p5)
# print('{}-{}-{}-{}-{}'.format(l1, l2, l3, l4, l5))

# def director(word, direction, times):
#     for _ in range(times):
#         if direction == 0:
#             word = word[1:] + word[0]
#         elif direction == 1:
#             word = word[-1] + word[:-1]
#     return word

# def erotate(string, directions, times):
#     netTimes = times[0] - times[1]
#     if netTimes > 0:
#         string = director(string, directions[0], netTimes)
#     else:
#         string = director(string, directions[1], abs(netTimes))

#     # for i in range(2):
#     #     string = director(string, directions[i], times[i])
#     return string
    
# print(erotate('teasdfgasdfghjkl;qwertyuiopzxcvbnm,.dfghjkldfghjkldfghjklfghjkhjklmi', [1, 0], [4344656, 7846759]))


# def estrange(mapping, nums):
#     num, el = '', []
#     for x in nums:
#         for i in x:
#             num += str(mapping.index(int(i)))
#         el += [int(num)]
#         num = ''
#     el.sort()
#     return el

# def strange(mapping, num):
#     no = ''
#     for i in num:
#         no += str(mapping.index(int(i)))
#     return int(no)
     
# def strangeSort(mapping, nums):
#     new = []
#     for i in estrange(mapping, nums):
#         for x in nums:
#             if strange(mapping, x) == i: 
#                 new += [x]
#                 nums.remove(x)
#     return new

# print(strangeSort([0,1,2,3,4,5,6,7,8,9 ], ['9', '100', '84', '99', '003', '53', '28', '60', '1', '070']))

# d = {10: '12', 60: '02', 2: '224', 49: '65', 95: '53', 96: '50'}
# d.pop(10)
# print (d)
# def strangesort(mappings, nums):
#     arr = strange(mapping, nums)
#     new = []
#     for i in nums:
#         if 


# print(strange([2, 1, 4, 8, 6, 3, 0, 9, 7, 5, 8 ], '12'))


# def strangesort(mappings, nums):
#     arr, fin, c, d = [], [], 0, 0
#     for _ in range(len(nums)):
#         arr += strange(mappings, nums[c])
#         c += 1
#         arr.sort()
#     for i in nums:
         
#                 fin += [x]
#     return fin


# print(strangesort([1, 8, 2, 5, 3, 0, 4, 7, 6, 9 ], ['32', '990', '332']))

# l = [1 ,2 ,3]
# l += [1]
# print (l)


# def subArray(array, S):
#     a, b = 0, 1
#     for _ in array:
#         for _ in array:
#             if sum(array[a:b]) == S:
#                 return array[a:b]
#             b += 1
#         a += 1
#         b = a + 1
# print(subArray([1,2,3,4,6,7,8,9,10], 20))
# ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F']

# def fromBase10(number, otherBase):
#     dic, ans = '0123456789ABCDEF', ''
#     while number > 0:
#         ans += dic[(number%otherBase)]
#         number = number//otherBase
#     return ans[::-1]

# print(fromBase10(5062, 16))

# def toBase10(number, base):
#     a, b, dic = 0, 0, '0123456789ABCDEF'
#     if type(number) == str:  number = [dic.index(x) for x in number]
#     else: number = str(number)
#     for i in number[::-1]:
#         a += int(i) * (base**b)
#         b += 1
#     return a

# print(toBase10('13C6', 16))

# print()

# def check1(num):
#     l = '123456'
#     for i in str(num):
#         if i not in l:
#             return False
#     return True

# # print(check1(5555))

# # def check2(num):
# #     l = '123456'
# #     for i in l:
# #         if str(num).count(i) > 1: return False
# #     return True
# # print(check2(9875))
# # count = 0
# # for i in range(5001, 6001):
# #     if check1(i): count -= -1
# #     else: pass
# print(count)


# a, b, = 3, 4
# a &= 4
# print(a)























































































































# def right(word, times):
#     for _ in range(times):
#         word = word[-1] + word[:-1]
#     return word

# def left(word, times):
#     for _ in range(times):
#         word = word[1:] + word[0]
#     return word


# def rotate(string, directions, time):
#     string = right(string, (time[directions[1]]))
#     string = left(string, (time[directions[0]]))
#     return string