using System;

public class NotCarFoundException : Exception {
    public NotCarFoundException(string message) : base(message) {
    }
}