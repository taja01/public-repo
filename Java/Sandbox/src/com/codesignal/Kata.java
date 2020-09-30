package com.codesignal;

public class Kata {
   public static boolean areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
       return Math.max(yourLeft, yourRight) == Math.max(friendsLeft, friendsRight)
               && Math.min(yourLeft,yourRight) == Math.min(friendsLeft,friendsRight);
    }
}
