
namespace RSAEncryptandDecrypt
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Private and Public key Encryption
            var privateKey = @"-----BEGIN RSA PRIVATE KEY-----
            MIIEowIBAAKCAQEA0kJujbZsq3xKnXU6bFfigEA5yGZi8ZQPZpngxfB6vtzCgIAA
            LWTjZIzF3bwq5jP+wJoS+rEpA/hQVrIoKGMIX7GgytbkXaMIn/1OO8UNPxrSa23x
            rTm4wTsb+/NhcqxHSr/hx8NAUC11/PVZ+f5dRl+XcrX/S4do5ELJ9/CiogOAANdu
            jPbM9CDs2rrbanL/Qkw1UJqgqCTbbKDSU2C3nrU8gNFjjjsk4CKzcqxG6CLBsRqQ
            0RD8LrHHp1u5OHDXVeL5E8fv1bMfnFiHXbRsuq0qr2SOcJm3deJMoKxrEhRfxwvk
            cNuw4i1dJuBzId03Ee25WTJMeUAszqmvky+SQwIDAQABAoIBABo0fWLcIZ8d1o7Z
            VXa7XVduqcT4PcyuD11SQFlrJ2EyUmuBiIQf1tdpVB/Wm+IlCNMoYMUt31bHU/v6
            KFcgQKLsmIWvUrb44tJN17pLTONYjHEnOr/EOeqbW1mDc9m+7wO59oHXK+TSRapJ
            SfWGZkmnEFETrcXUEpagXFuyehKG80UzhJGjhxvh8k0EIud6TnQmS38y742jM9RU
            W0s4p9QX+Ec854E4qYQR0PAg+xvDeyE6RijE6f5vNh3ou9x6CU/gZsNKD7vIqr1B
            iSg5eXaqRxovg85NH2WKoLUOAVGxjLoqa6ulRQJnxx2zovueplqfGoL8pMfw6aX6
            luiC5MECgYEA8SxCPNBuHnMfDENDy4WG6/H3HIjmxSli8TYgS1Xl28mya5TZOs/i
            QBkYvH373U+/o7pXNqcIhn80HomgC37k7s1kxn5Hz83OGFmd5qmzVGMaikw6rRiC
            VdfW6tSF/30eaLsqiU3lwT7neJgyHpx5KtR/X2B+qEILW+4J+nFRTZcCgYEA3y+j
            LhCG5zA821vW2F5deOjhhOzcQ8hjF1wbPgokwtxJ40ANwwEJk2QlI0ZeUiDUvAek
            yCQredfSRCkNXNMv9UK8K/L/p36684SJyMP4BAc4bpoeKJ8FJlxJ3qxY3m2BbEYT
            0kvNC7rxWPoo6vwwFXowQlZAj8MwQL1jYMnNzjUCgYEAmvWCFcsihiQX9eweWl2Q
            RHfy+/2msVYXQb8yXtVxXJgrMN6x+QzrZZ36e9pDA38jNlMbiH0oiCqhVWG+WMSO
            2jVUpAktoQKugozKXRP6qqUGv4edR+zwibGmYLpu4qsE5+wit5g6oMEHP0AjK/IE
            FJX2xVSd7QSKgeXfuXAn+j8CgYB3xJeb47CRJdiympEroVAlz0seSwFUupc6dOoF
            m+noS9C2y6vW5pqd5tLrIBsDlayzjqKF6KsQAppKi4EpPAdzZTGXoBpDZwWqIojS
            HR/eAYXuDHR8tgFMeaAGh5RVIIygbua6JoVNcy+K4QvONjEThXOaVbDltQgS5c8L
            pJ/1tQKBgGXvNfbk5quY5G20Lu6NHnCj+2WMdv1apvUwwQIfuDPpCzz7O4coQbQr
            g4T38eFy5yfNjJIzvuHcT8kl8kASB1tBQrwkksHFzaJ9YyYDNWJMCLAktha6JlyX
            +NXRh4lUmhQpdhi/KW5mG2gDGkIRRCyVAhI/y7Kw3XbUGV/SxSDv
            -----END RSA PRIVATE KEY-----";

            var publicKey = @"-----BEGIN PUBLIC KEY-----
            MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA0kJujbZsq3xKnXU6bFfi
            gEA5yGZi8ZQPZpngxfB6vtzCgIAALWTjZIzF3bwq5jP+wJoS+rEpA/hQVrIoKGMI
            X7GgytbkXaMIn/1OO8UNPxrSa23xrTm4wTsb+/NhcqxHSr/hx8NAUC11/PVZ+f5d
            Rl+XcrX/S4do5ELJ9/CiogOAANdujPbM9CDs2rrbanL/Qkw1UJqgqCTbbKDSU2C3
            nrU8gNFjjjsk4CKzcqxG6CLBsRqQ0RD8LrHHp1u5OHDXVeL5E8fv1bMfnFiHXbRs
            uq0qr2SOcJm3deJMoKxrEhRfxwvkcNuw4i1dJuBzId03Ee25WTJMeUAszqmvky+S
            QwIDAQAB
            -----END PUBLIC KEY-----";

            var privateKey1 = @"-----BEGIN RSA PRIVATE KEY-----
            MIIEpQIBAAKCAQEAuMPT3qSYeGab/Tmz5DXazx/9G+vPO0Sqk7pry9h6z04+u3if
            rfXGTQK5hJWWXAAeX8q+xhCBVhfbYmKmGjvvOrAcUEF58Rk0P1xp3rlDa5Vg45sr
            LwCQ9gGUqcRamUhrbl0LFQz/gE7nZoK2U6Pc4wbTpvxPFmF+M4RP+l6DrrAq8D3g
            kJlnmzNvF9rCrWowE9jVrvePfHrhzrFJQY3KdkJICTO3JWLTO4sA10TO7Y8XNPQK
            uxfwXE0MbIv9aajsFN/Xt9APdYomq0DEiewFquyCP0Bxwx1W1ROkgXzyi/1DZpuP
            l/th3K/zpqYQc9DAuGxTiSAuj68Ghc5/TDQO2QIDAQABAoIBAFRwcqB6uo+z3TBC
            Mbtm/WPRa7xZ7XBZtlcjSGZ1vdKGINdOjjNTclf5mc1FC91p1HfU0ZD1NBajeoih
            KuYsY+1/VME82zzbVuxqEJxQMMa3EvuSC49Eg/tZx5Y6fWk2FprufMUXFqGN7eUE
            cc0Rwz4h/ZKAFqjUz3c9zctPbIDljEeUHk0JxMn6M+4sMIUJgiyXAkcEK0Yg0kRY
            KaO9S7VFkYWu2Ut7Eapo/xbNw53dS+q7FNAVsj3xwtWDUcc7y8uwp1YoP9EUQTus
            jhMACeQTYHC6XPV8WAdoIy4Br7agbMp5qU76WciNpGoWVpGsOI7zue9HllxfS7IA
            RhyzkPECgYEA8BLhFWJ94/4F6s6rH3dBZT8aZrTi/ZMRWYKNb90x9EXlRecBVqIx
            sguO4sQfsxLmf/nke0nefXH2bkRRkGdPvn6M/s+PYiGIhU1758jABcayi1TJSF4Z
            4BhXX4IjoxGQXGx+WdW1VAVBwXUyZW96/iBOMU+h1N21+h3lOnjhMcUCgYEAxQWm
            qREHa8CJu/oSQSwSw53EIIv0BPbfl8IQOYhnOfTlvbxplYutH70lcqtHjQGijLeh
            Cgax9FMRfTsKHTCXxQhVBtD9ji3TMuJzUJL/mOmpA904BogOCnznHuJDeXoZc5KC
            LCehYBn8Dked+LY0uz33iysPrt6Mx4Dt7RilHgUCgYEAu9RZjEyp6FZXtNWLZyv7
            20Ya1t6Rdgm5mkmddTcfnVmOPzm0f16Y+Q839M2za3zPILOYAqnRzF38i1siYZOi
            /YyvrbEhIorP8FOmLLuRGTPTf1WPwfH11rHUsmH0leHpC5bK6Ghe3WTbhIu4KUqm
            dOs7ojMGj7ADb7QyI6RttG0CgYEAlxhiW74nhsc92d9KKJj4OvS++IbcOQJrLyMw
            9i5Zm+ToW74m6v0XZAPWuD4KvWTHmEsrQVkpGEqsWvHwK7qcagqdyoB0M5mJIrjv
            3pcdVdO8Pq5kzP2CZyCqztCPFpZA9pUhJ2OtKtpCp2DdEWQKxJ4dPalkeaNLK6UA
            0pfX6VECgYEA2CK4ysX41ufU1v6EF+ww2VvxFuvu6UzcJmuMi6XREKK/0vOrV6wm
            Wyo4LsRb9Nmd1ZnPfVEzO2Hd0tmCVtqBeGCpIN56SAwuwkKmRUoY/shh5UOTdsKD
            EQHzJ8e4vP141J6A4ydaikp5OCThB+4EvyU7VZNLTNEAIhXq92YnrI8=
            -----END RSA PRIVATE KEY-----";


            var publicKey1 = @"-----BEGIN PUBLIC KEY-----
            MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAuMPT3qSYeGab/Tmz5DXa
            zx/9G+vPO0Sqk7pry9h6z04+u3ifrfXGTQK5hJWWXAAeX8q+xhCBVhfbYmKmGjvv
            OrAcUEF58Rk0P1xp3rlDa5Vg45srLwCQ9gGUqcRamUhrbl0LFQz/gE7nZoK2U6Pc
            4wbTpvxPFmF+M4RP+l6DrrAq8D3gkJlnmzNvF9rCrWowE9jVrvePfHrhzrFJQY3K
            dkJICTO3JWLTO4sA10TO7Y8XNPQKuxfwXE0MbIv9aajsFN/Xt9APdYomq0DEiewF
            quyCP0Bxwx1W1ROkgXzyi/1DZpuPl/th3K/zpqYQc9DAuGxTiSAuj68Ghc5/TDQO
            2QIDAQAB
            -----END PUBLIC KEY-----";

            // // Set up 
            var input = "Preethamcheckpassword";
            var enc = new EncryptionClass();

            // Encrypt it
            var encryptedWithPublic = enc.RsaEncryptWithPublic(input, publicKey);

            // Decrypt
            var output1 = enc.RsaDecryptWithPrivate(encryptedWithPublic, privateKey);

            //var output2 = enc.RsaDecryptWithPublic(encryptedWithPrivate, publicKey);

            // Console.WriteLine(output1 == output2 && output2 == input);

            Console.WriteLine(encryptedWithPublic + Environment.NewLine + output1);
            Console.Read();



            #endregion

            #region password salt checking
            ///////for checking salt password//////////////////

            //const string passwordToHash = "SamplePassword";

            //var enc = new Passwordsalt();
            //enc.HashPasswords(passwordToHash, 1000);
            //Console.ReadLine();

            #endregion
        }

    }

}