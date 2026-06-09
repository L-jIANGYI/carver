using Carver.Forms;
using Carver.Models;

namespace Carver
{
    internal partial class MainForm
    {
        private void LoadUsers()
        {
            dgvUsers.DataSource = _userService.GetAllUsers();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            User? selected = dgvUsers.Rows[e.RowIndex].DataBoundItem as User;
            if (selected == null) return;

            if (e.ColumnIndex != colBtnDelete.Index) return;

            var result = MessageBox.Show(
                $"Weet je zeker dat je {selected.Name} wilt verwijderen?",
                "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _userService.Delete(selected);
                MessageBox.Show("Gebruiker verwijderd.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }
    }
}
