echo OFF
clear
# Clear build directories
# Clear library project build directories
rm -rf "library/bin"
rm -rf "library/obj"

# Clear sample project build directories
rm -rf "samples/AndroidIconicsSample/bin"
rm -rf "samples/AndroidIconicsSample/obj"

# Build sample project to ensure that binded library referenced correctly.
xbuild "/p:Configuration=Release" /t:SignAndroidPackage samples/AndroidIconicsSample/AndroidIconicsSample.csproj 
# xbuild "/p:Configuration=Release;AdbTarget=-d -r" /t:Clean,Install samples/AndroidIconicsSample/AndroidIconicsSample.csproj 

# Create NuGet package
mono "dev/.nuget/NuGet.exe" pack -Verbosity detailed -NoDefaultExcludes "dev/Mikepenz.Android.Iconics.Xamarin.Binding.Mac.nuspec"

echo "Successfully built project."

