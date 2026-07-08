import os 
import copy
import tkinter as tk
from tkinter import font
import subprocess
class tApp:
    def __init__(self, root,texts,titles):
        self.root = root
        self.root.title(titles)
        self.root.geometry("800x600")
        self.root.configure(bg="white")

        # Frame com barra de scroll
        self.frame = tk.Frame(self.root, bg="white")
        self.frame.pack(fill="both", expand=True)
        self.frame2 = tk.Frame(self.root, bg="white")
        self.frame2.pack(fill="x", expand=False)

        # Canvas para desenhar texto
        self.canvas = tk.Canvas(self.frame, bg="white", highlightthickness=0)
        self.canvas.pack(side="left", fill="both", expand=True)

        # Barra de scroll vertical
        self.scrollbar = tk.Scrollbar(self.frame, orient="vertical", command=self.canvas.yview)
        self.scrollbar.pack(side="right", fill="y")
        self.canvas.configure(yscrollcommand=self.scrollbar.set)
        self.scrollbarx = tk.Scrollbar(self.frame2, orient="horizontal", command=self.canvas.xview)
        self.scrollbarx.pack(side="bottom", fill="x")
        self.canvas.configure(xscrollcommand=self.scrollbarx.set,height=35)

        # Fonte
        self.font = font.Font(family="Courier", size=16)
        ff=texts.split("\n")
        y=20
        for t in ff:
            tt=self.canvas.create_text(10, y, text=t, anchor="nw", font=self.font, fill="red")
            tt=self.canvas.create_line(0,y-4,800,y-4, fill="black")
            y=y+22
        self.canvas.configure(scrollregion=self.canvas.bbox("all"))
        # Scroll automático para o fim
        self.canvas.yview_moveto(0.0)
        self.canvas.xview_moveto(0.0)
        self.root.protocol("WM_DELETE_WINDOW", self.close)
    def saveps(self):
        self.canvas.postscript(file="output.ps", colormode="color")

        

    def close(self):
        self.saveps()
        self.root.destroy()
print("\033c\033[47;31m\ngive me a text to view ? \n")
a=input().strip()

f1=open(a,"r")
f=f1.read()
f1.close()

root = tk.Tk()

app = tApp(root,f,a)
root.mainloop()
