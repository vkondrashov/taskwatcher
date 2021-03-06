﻿using System;
using System.Collections.Generic;
using System.Linq;

using TaskWatcher.Common;
using TaskWatcher.Import;

namespace TaskWatcher.Console
{
    class RepositoryCommands
    {
        private readonly RepositoryManager _manager;

        public RepositoryCommands(RepositoryManager manager)
        {
            _manager = manager;
        }

        [Command(CommandType.Repository, "repos", Help = "Lists available repositories")]
        public void ListRepositories()
        {
            // doing nothing here
        }

        [Command(CommandType.Repository, "repoadd", Help = "Creates new repository")]
        public void CreateRepository(string repoName, string repoPath = null)
        {
            _manager.CreateRepository(repoName, repoPath);
        }

        [Command(CommandType.Repository, "reposet", Help = "Sets current repository")]
        public void SetCurrentRepository(string repoName)
        {
            _manager.SetCurrentRepository(repoName);
        }

        [Command(CommandType.Repository, "repodel", Help = "Deletes repository")]
        public void DeleteRepository(string repoName)
        {
            _manager.DeleteRepository(repoName);
        }

        [Command(CommandType.Repository, "repopath", Help = "Sets path for repository")]
        public void SetRepositoryPath(string repoName, string repoPath = null)
        {
            _manager.SetRepositoryPath(repoName, repoPath);
        }
    }
}
