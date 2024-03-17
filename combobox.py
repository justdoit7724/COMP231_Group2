from tkinter import ttk
import tkinter as tk
def dropdown_opened():
    print("Lista desplegada.")
main_window = tk.Tk()
main_window.config(width=300, height=200)
main_window.title("Combobox")
combo = ttk.Combobox(
    values=["option1", "option2", "option3", "option4"],
    postcommand=dropdown_opened
)
combo.place(x=50, y=50)
main_window.mainloop()
