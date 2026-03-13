using System;
using System.Collections.Generic;
using System.Text;

class FilePathValidator
{
    public void ValidatePath(string path)
    {

        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentNullException(paramName: null,"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
        }
        else if (path.IndexOfAny(new char[] { '<', '>', '|', '"', '*', '?' }) >= 0)
        {
            int index = path.IndexOfAny(new char[] { '<', '>', '|', '"', '*', '?' });
            char foundChar = path[index];
            throw new ArgumentException($"[Argument 오류] 경로에 금지 문자 {foundChar}가 포함되어 있습니다.");
        }
        else if (path.Length >= 260)
        {
            throw new ArgumentOutOfRangeException(paramName: null, "[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
        }
            Console.WriteLine($"경로가 유효합니다: {path}");
    }
    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        foreach (string extension in allowedExtensions)
        {
            if (path.Equals(extension))
            {
                Console.WriteLine($"확장자가 유효합니다: {path}");
                return;
            }
        }
        throw new ArgumentException($"[Argument 오류] 허용되지 않은 확장자입니다: {path}");
    }
}