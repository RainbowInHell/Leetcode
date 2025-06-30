namespace LanguageMasteryChallenges.LeetCode;

public static class _1233RemoveSubFoldersFromTheFilesystem
{
    public static IList<string> RemoveSubfolders(string[] folders)
    {
        var spanOfFolders = folders.AsSpan();
        spanOfFolders.Sort();

        var lastChecked = spanOfFolders[0];
        var result = new List<string>(folders.Length) { folders[0] };

        for (var i = 1; i < spanOfFolders.Length; i++)
        {
            var currentSubfolder = spanOfFolders[i];
            if (currentSubfolder.Length > lastChecked.Length &&
                currentSubfolder.StartsWith(lastChecked) &&
                currentSubfolder[lastChecked.Length] == '/')
            {
                continue;
            }

            lastChecked = currentSubfolder;
            result.Add(folders[i]);
        }

        return result;
    }
}