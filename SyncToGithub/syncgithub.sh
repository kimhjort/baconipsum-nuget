git clone --bare https://kimhjort.visualstudio.com/BaconIpsumGen/_git/BaconIpsumGen
# Makes a bare clone of the external repository in a local directory

cd BaconIpsumGen
git push --mirror https://github.com/xobsdk/baconipsum-nuget.git
# Pushes the mirror to the new GitHub repository

cd ..
rm -rf BaconIpsumGen
# Removes cloned repo