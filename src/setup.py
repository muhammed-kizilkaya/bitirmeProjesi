import sys
import os
from cx_Freeze import setup, Executable

files = ['icon.ico']

target = Executable(
    script = "main.py",
    base="Win32GUI",
    icon="icon.ico"
)

setup(
    name = "Etu APP",
    version= "1.0",
    description="Gui exe",
    author="Clay",
    options={'build_exe': {'include_files': files}}, executables= [target]
)