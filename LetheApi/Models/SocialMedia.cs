﻿namespace LetheApi.Models;

public class SocialMedia
{
    public int Id { get; set; }
    public string PathName { get; set; } = string.Empty; // Facebook
    public string Path { get; set; } = string.Empty; // M20,3H4C3.447,3,3,3.448,3,4v16c0,0.552,0.447,1,1,1h8.615v-6.96h-2.338v-2.725h2.338v-2c0-2.325,1.42-3.592,3.5-3.592 c0.699-0.002,1.399,0.034,2.095,0.107v2.42h-1.435c-1.128,0-1.348,0.538-1.348,1.325v1.735h2.697l-0.35,2.725h-2.348V21H20 c0.553,0,1-0.448,1-1V4C21,3.448,20.553,3,20,3z
    public string PathUrl { get; set; } = string.Empty; // e.g., https://www.facebook.com/LetheApi
}
