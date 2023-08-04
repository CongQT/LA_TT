import { Button, Form, Input, Radio } from "antd";
import { Link } from "react-router-dom";

function DangKiPTComponent(){
    return (
    <div className="dangki">
    <div className="title">
      Đăng kí
    </div>
    <Form
    layout="vertical"
    name="form_in_modal"
    initialValues={{
      modifier: 'public',
    }}
    
  >
    <Form.Item
    name="email"
    label="Email"
    rules={[
        {
        required: true,
        message: 'Điền email',
        },
    ]}
    className="in"
    >
    <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
      name="matkhau"
      label="Mật khẩu"
      rules={[
        {
          required: true,
          message: 'Điền mật khẩu',
        },
      ]}
      className="in"
    >
      <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
      name="Ho"
      label="Họ"
      rules={[
        {
          required: true,
          message: 'Điền họ',
        },
      ]}
      className="in"
    >
      <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
      name="Tên"
      label="Tên"
      rules={[
        {
          required: true,
          message: 'Điền tên',
        },
      ]}
      className="in"
    >
      <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
      name="phapdanh"
      label="Pháp danh"
      rules={[
        {
          required: true,
          message: 'Điền pháp danh',
        },
      ]}
      className="in"
    >
      <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
      name="Ngaysinh"
      label="Ngày sinh"
      rules={[
        {
          required: true,
          message: 'Điền ngày sinh',
        },
      ]}
      className="in"
    >
      <Input style={{width:'300px'}}/>
    </Form.Item>
    
    <Form.Item
      name="Sdt"
      label="Sđt"
      rules={[
        {
          required: true,
          message: 'Điền sđt',
        },
      ]}
      className="in"
    >
      <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
      name="Gioitinh"
      label="Giới tính"
      rules={[
        {
          required: true,
          message: 'Điền giới tính',
        },
      ]}
      className="in"
    >
      <Radio.Group>
          <Radio value="Nam">Nam</Radio>
          <Radio value="Nữ">Nữ</Radio>
      </Radio.Group>
    </Form.Item>

  </Form>
  <Button className="dangkibt">
    <Link to={"/dangnhap"}>Đăng kí</Link>
  </Button>
    </div>
    )
}
export default DangKiPTComponent;